using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.DAL;
using HiTechLibrary.VALIDATION;

namespace HiTechWindowsFormsApp.GUI
{
    public partial class CustomerForm : Form
    {
        SqlDataAdapter da;
        DataSet dsCustomerDB;
        DataTable dtCustomers;

        public CustomerForm()
        {
            InitializeComponent();
            dsCustomerDB = CustomerDS.GetCustomerDS();
            dtCustomers = dsCustomerDB.Tables["Customers"];
            da = CustomerDS.CustomersDataAdapter();
        }

        //Clear textboxes
        public void ClearTextBoxes(Control.ControlCollection controls)
        {

            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }

                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    ClearTextBoxes(groupBox.Controls);
                }
            }
        }

        //list Customer data from dataset
        private void button_ListCustomersfromDS_Click(object sender, EventArgs e)
        {
            dataGridViewListCustomersDS.DataSource = dsCustomerDB.Tables["Customers"];
        }

        //List customer data from Database
        private void button_ListCustomersfromDB_Click(object sender, EventArgs e)
        {
            

            Customer customer = new Customer();

            dataGridViewListCustomersDB.DataSource = customer.GetAllCustomer();
        }

        //save customer data
        private void button_Save_Click(object sender, EventArgs e)
        {
            textBoxCustomerID.Enabled = false;
            if (!ValidateInput())
            {
                return; // Validation failed, exit the method
            }

            MessageBox.Show("Customer ID will be created automatically.");

            DataRow dr = dtCustomers.NewRow(); 

            dr["FirstName"] = textBoxCustomerFirstName.Text.Trim();
            dr["LastName"] = textBoxCustomerLastName.Text.Trim();
            dr["Street"] = textBoxCustomerStreet.Text.Trim();
            dr["City"] = textBoxCustomerCity.Text.Trim();
            dr["PostalCode"] = textBoxCustomerPostalCode.Text.Trim(); 
            dr["PhoneNumber"] = textBoxCustomerPhoneNumber.Text.Trim();
            dr["FaxNumber"] = textBoxCustomerFaxNumber.Text.Trim();

            dr["CreditLimit"] = textBoxCustomerCredtLimit.Text.Trim();

            dtCustomers.Rows.Add(dr);
            //re-enable textbox customer id
            textBoxCustomerID.Enabled=true;
            MessageBox.Show(dr.RowState.ToString(), "RowState in DataTable Customers");

            ClearTextBoxes(this.Controls);
        }

        //Update database
        private void button_Update_Click(object sender, EventArgs e)
        {
            da.Update(dsCustomerDB, "Customers");
            MessageBox.Show("Database has been update successfully.", "Database updated");
        }

        //Search Customer data with CustomerId
        private void button_Search_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(textBoxCustomerSearch.Text.Trim());
            DataRow foundRow = dtCustomers.Rows.Find(customerId);

            if (foundRow != null)
            {
                textBoxCustomerID.Text = foundRow["CustomerId"].ToString();
                textBoxCustomerFirstName.Text = foundRow["FirstName"].ToString();
                textBoxCustomerLastName.Text = foundRow["LastName"].ToString();
                textBoxCustomerStreet.Text = foundRow["Street"].ToString();
                textBoxCustomerCity.Text = foundRow["City"].ToString();
                textBoxCustomerPostalCode.Text = foundRow["PostalCode"].ToString();
                textBoxCustomerPhoneNumber.Text = foundRow["PhoneNumber"].ToString();
                textBoxCustomerFaxNumber.Text = foundRow["FaxNumber"].ToString();
                textBoxCustomerCredtLimit.Text = foundRow["CreditLimit"].ToString();
            }
            else
            {
                MessageBox.Show("Customer not found.", "Invalid Customer ID");
            }
        }

        //Modify customer data
        private void button_Modify_Click(object sender, EventArgs e)
        {
           
            if (!ValidateInput())
            {
                return; // Validation failed, exit the method
            }

            int searchId = Convert.ToInt32(textBoxCustomerID.Text);

            DataRow drCustomer = dtCustomers.Rows.Find(searchId);

            if (drCustomer == null)
            {
                MessageBox.Show($"No customer found with id = {textBoxCustomerID.Text}", "Invalid Customer ID");
                return;
            }

            drCustomer["FirstName"] = textBoxCustomerFirstName.Text.Trim();
            drCustomer["LastName"] = textBoxCustomerLastName.Text.Trim();
            
            drCustomer["Street"] = textBoxCustomerStreet.Text.Trim();
            drCustomer["City"] = textBoxCustomerCity.Text.Trim();
            drCustomer["PostalCode"] = textBoxCustomerPostalCode.Text.Trim();
            drCustomer["PhoneNumber"] = textBoxCustomerPhoneNumber.Text.Trim();
            drCustomer["FaxNumber"] = textBoxCustomerFaxNumber.Text.Trim();
            drCustomer["CreditLimit"] = textBoxCustomerCredtLimit.Text.Trim();

            MessageBox.Show("The row state in the DataTable Customers : " + drCustomer.RowState);

            ClearTextBoxes(this.Controls);
        }

        //Delete Customer
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValid(textBoxCustomerID.Text,3))
            {
                MessageBox.Show("Customer Id is Not Valid!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Do you want to delete the customer with ID = {textBoxCustomerID.Text.Trim()} ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int searchId = Convert.ToInt32(textBoxCustomerID.Text);

            DataRow drCustomer = dtCustomers.Rows.Find(searchId);

            if (drCustomer == null)
            {
                MessageBox.Show($"No customer found with id = {textBoxCustomerID.Text}", "Invalid Customer ID");
                return;
            }

            drCustomer.Delete();

            MessageBox.Show("The row state in the DataTable Customers : " + drCustomer.RowState);

            ClearTextBoxes(this.Controls);
        }

        //Close Button
        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to logOut?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (answer == DialogResult.Yes)
            {
                this.Close();
               /* LogInForm logInForm = new LogInForm();
                logInForm.ShowDialog();
                this.Show();*/
            }
        }



        //validation Messages
        public bool ValidateInput()
        {
            // Validate First Name
            string input = textBoxCustomerFirstName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid First Name.", "Invalid");
                textBoxCustomerFirstName.Clear();
                textBoxCustomerFirstName.Focus();
                return false;
            }

            // Validate Last Name
            input = textBoxCustomerLastName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid");
                textBoxCustomerLastName.Clear();
                textBoxCustomerLastName.Focus();
                return false;
            }

            // Validate Street
            input = textBoxCustomerStreet.Text.Trim();
            if (!Validator.IsValidStreetAddress(input))
            {
                MessageBox.Show("Invalid Street Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerStreet.Clear();
                textBoxCustomerStreet.Focus();
                return false;
            }

            // Validate City
            input = textBoxCustomerCity.Text.Trim();
            if (!Validator.IsValidCity(input))
            {
                MessageBox.Show("Invalid City.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerCity.Clear();
                textBoxCustomerCity.Focus();
                return false;
            }

            // Validate Postal Code
            input = textBoxCustomerPostalCode.Text.Trim();
            if (!Validator.IsValidPostalCode(input))
            {
                MessageBox.Show("Invalid Postal Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerPostalCode.Clear();
                textBoxCustomerPostalCode.Focus();
                return false;
            }
            // Validate Phone Number
            input = textBoxCustomerPhoneNumber.Text.Trim();
            if (!Validator.IsValidPhoneNumber(input))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerPhoneNumber.Clear();
                textBoxCustomerPhoneNumber.Focus();
                return false;
            }

            // Validate Fax Number
            input = textBoxCustomerFaxNumber.Text.Trim();
            if (!Validator.IsValidFaxNumber(input))
            {
                MessageBox.Show("Invalid Fax Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerFaxNumber.Clear();
                textBoxCustomerFaxNumber.Focus();
                return false;
            }

            // Validate Credit Limit
            input = textBoxCustomerCredtLimit.Text.Trim(); 
            if (!Validator.IsValidCreditLimit(input))
            {
                MessageBox.Show("Invalid Credit Limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCustomerCredtLimit.Clear();
                textBoxCustomerCredtLimit.Focus();
                return false;
            }

            return true; // All validations passed
        }

        
    }
    
}
