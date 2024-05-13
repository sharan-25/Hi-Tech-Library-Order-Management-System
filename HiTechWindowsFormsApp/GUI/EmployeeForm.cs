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
using HiTechLibrary.DAL;
using HiTechLibrary.VALIDATION;

namespace HiTechWindowsFormsApp.GUI
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
       
        

        private void button_Save_Click(object sender, EventArgs e)
        {
            //Check Empty Input
            if (Validator.IsInputEmpty(textBoxEmployeeFirstName.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeeLastName.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeeEmail.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeePhoneNumber.Text.Trim()) || Validator.IsInputEmpty(comboBoxEmployeeJobID.Text) || Validator.IsInputEmpty(comboBoxEmployeeStatusID.Text))
            {
                MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validate user input
            if (!ValidateInput())
            {
                return; // Validation failed, exit the method
            }

            // Save the valid data
            Employee employee = new Employee();

            // Disable employee ID textbox during save
            textBoxEmployeeID.Enabled = false;
            employee.FirstName = textBoxEmployeeFirstName.Text.Trim();
            employee.LastName = textBoxEmployeeLastName.Text.Trim();
            employee.PhoneNumber = textBoxEmployeePhoneNumber.Text.Trim();
            employee.Email = textBoxEmployeeEmail.Text.Trim();
            employee.StatusId = Convert.ToInt32(comboBoxEmployeeStatusID.Text.Trim());
            employee.JobId = Convert.ToInt32(comboBoxEmployeeJobID.Text.Trim());
            employee.SaveEmployee(employee);

            // Re-enable employee ID textbox after saving
            textBoxEmployeeID.Enabled = true;
            MessageBox.Show("EmployeeId will be created automatically!");
            MessageBox.Show("Saved successfully!", "Confirmation");
            clearTextBox();
            textBoxEmployeeID.Focus();
        }

        //Search button
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchEmployeeOpton.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option.", "Search Option",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee();
            List<Employee> listEmp = new List<Employee>();
            switch (comboBoxSearchEmployeeOpton.SelectedIndex)
            {

                case 0:
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int employeeId;
                    if (!int.TryParse(textBoxEmployeeSearch.Text, out employeeId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmployeeID.Clear();
                        return;
                    }
                    employee = employee.SearchEmployee(Convert.ToInt32(textBoxEmployeeSearch.Text));
                if (employee != null)
                {
                        clearTextBox();
                    textBoxEmployeeID.Text = employee.EmployeeId.ToString();
                    textBoxEmployeeFirstName.Text = employee.FirstName.ToString();
                    textBoxEmployeeLastName.Text = employee.LastName.ToString();
                    textBoxEmployeePhoneNumber.Text = employee.PhoneNumber.ToString();
                    textBoxEmployeeEmail.Text = employee.Email.ToString();
                    comboBoxEmployeeStatusID.Text = employee.StatusId.ToString();
                    comboBoxEmployeeJobID.Text = employee.JobId.ToString();

                }
                else
                {
                    MessageBox.Show("Employee not found!", "Invalid EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmployeeSearch.Clear();
                    textBoxEmployeeSearch.Focus();
                    return;
                }
                    break;
                case 1:
                    // search by First Name
                    clearTextBox();
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    listEmp = employee.SearchEmployee(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not found!", "Invalid First Name.");
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                    }
                    break;
                case 2: // search by Last Name
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    clearTextBox();
                    listEmp = employee.SearchEmployee(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not found!", "Invalid Last Name");
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                    }


                    break;
                case 3: // Search by Email
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (!Validator.IsValidEmail(textBoxEmployeeSearch.Text.Trim()))
                    {
                        MessageBox.Show("Invalid Email format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    clearTextBox();
                    listEmp = employee.SearchEmployee(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not found!", "Invalid Email");
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                    }
                    break;
                case 4: // Search by Phone Number
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (!Validator.IsValidPhoneNumber(textBoxEmployeeSearch.Text.Trim()))
                    {
                        MessageBox.Show("Invalid Phone Number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    clearTextBox();
                    listEmp = employee.SearchEmployee(textBoxEmployeeSearch.Text.Trim());
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not found!", "Invalid Phone Number");
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                    }
                    break;
                case 5:
                    clearTextBox();
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int jobId;
                    if (!int.TryParse(textBoxEmployeeSearch.Text, out jobId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmployeeID.Clear();
                        return;
                    }
                    jobId = Convert.ToInt32(textBoxEmployeeSearch.Text);
                    listEmp = employee.SearchEmployeebyId(jobId);
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                        return;
                    }
                    break;
                case 6:
                    clearTextBox();
                    //validation
                    if (Validator.IsInputEmpty(textBoxEmployeeSearch.Text))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int statusId;
                    if (!int.TryParse(textBoxEmployeeSearch.Text, out statusId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmployeeID.Clear();
                        return;
                    }
                    statusId = Convert.ToInt32(textBoxEmployeeSearch.Text);
                    listEmp = employee.SearchEmployeebyId(statusId);
                    if (listEmp.Count != 0)
                    {
                        DisplayInfo(listEmp, dataGridViewListEmployeeData);
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!", "Invalid EmployeeId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmployeeSearch.Clear();
                        textBoxEmployeeSearch.Focus();
                        return;
                    }
                    break;
            }

        }

        public void clearTextBox()
        {
            //clear textbox
            textBoxEmployeeID.Clear();
            textBoxEmployeeFirstName.Clear();
            textBoxEmployeeLastName.Clear();
            textBoxEmployeePhoneNumber.Clear();
            textBoxEmployeeEmail.Clear();
            comboBoxEmployeeStatusID.SelectedIndex = -1;
            comboBoxEmployeeJobID.SelectedIndex = -1;
        }

        //Update Button
        private void button_Update_Click(object sender, EventArgs e)
        {
            //validation
            if (Validator.IsInputEmpty(textBoxEmployeeID.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeeFirstName.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeeLastName.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeeEmail.Text.Trim()) || Validator.IsInputEmpty(textBoxEmployeePhoneNumber.Text.Trim()) || Validator.IsInputEmpty(comboBoxEmployeeJobID.Text) || Validator.IsInputEmpty(comboBoxEmployeeStatusID.Text))
            {
                MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            // Parse the integer value
            int employeeId;
            if (!int.TryParse(textBoxEmployeeID.Text, out employeeId))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeID.Clear();
                return;
            }
            // Validate user input
            if (!ValidateInput())
            {
                return; // Validation failed, exit the method
            }
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text);
            employee.FirstName = textBoxEmployeeFirstName.Text;
            employee.LastName = textBoxEmployeeLastName.Text;
            employee.PhoneNumber = textBoxEmployeePhoneNumber.Text;
            employee.Email = textBoxEmployeeEmail.Text;
            employee.JobId = Convert.ToInt32(comboBoxEmployeeJobID.Text);
            employee.StatusId = Convert.ToInt32(comboBoxEmployeeStatusID.Text);
            employee.UpDateEmployee(employee);
            MessageBox.Show("Employee data has been updated successfully.", "Confirmation");
            //clear textbox
            clearTextBox();
        }

        //Delete Button
        private void button_Delete_Click(object sender, EventArgs e)
        {
            //Check Empty Input
            if (Validator.IsInputEmpty(textBoxEmployeeID.Text))
            {
                MessageBox.Show("Must provide value for Employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the integer value
            int employeeId;
            if (!int.TryParse(textBoxEmployeeID.Text, out employeeId))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeID.Clear();
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(textBoxEmployeeID.Text);
                employee.DeleteEmployee(employee);
                MessageBox.Show("Employee data has been deleted successfully!");
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }
        }

        //List All employees
        private void button_ListAll_Click(object sender, EventArgs e)
        {
            dataGridViewListEmployeeData.Rows.Clear();
            Employee employee = new Employee();

            List<Employee> listEmp = employee.GetAllEmployees();

            DisplayInfo(listEmp, dataGridViewListEmployeeData);
        }
        // Display information
        private void DisplayInfo(List<Employee> listEmp, DataGridView dataGridView)
        {
            // Clear existing rows and columns
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView.Columns.Add("EmployeeId", "Employee ID");
            dataGridView.Columns.Add("FirstName", "First Name");
            dataGridView.Columns.Add("LastName", "Last Name");
            dataGridView.Columns.Add("PhoneNumber", "Phone Number");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.Columns.Add("JobId", "Job ID");
            dataGridView.Columns.Add("StatusId", "Status ID");

            if (listEmp != null && listEmp.Count > 0)
            {
                foreach (Employee emp in listEmp)
                {
                    dataGridView.Rows.Add(emp.EmployeeId, emp.FirstName, emp.LastName, emp.PhoneNumber, emp.Email, emp.JobId, emp.StatusId);
                }
            }
            else
            {
                MessageBox.Show("No employee in the database.", "Missing Data");
            }
        }

        //Close button
        private void button_Close_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Do you really want to close the Employee Form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (answer == DialogResult.Yes)
            {
                this.Close();
               /* MainMenuForm form = new MainMenuForm();
                form.ShowDialog();
                this.Show();*/
            }
            
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //Fetching the data of statusId from the database to show in combobox
            comboBoxEmployeeStatusID.Items.Clear();

            using (SqlConnection connection = UtilityDB.ConnectDB())
            {
                string query = "SELECT StatusId FROM Status";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxEmployeeStatusID.Items.Add(reader["StatusId"].ToString());
                }

                reader.Close();
            }

            //Fetching the data of jobId from the database to show in combobox
            comboBoxEmployeeJobID.Items.Clear();

            using (SqlConnection connection = UtilityDB.ConnectDB())
            {
                string query = "SELECT JobId FROM Jobs";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxEmployeeJobID.Items.Add(reader["JobId"].ToString());
                }

                reader.Close();
            }
        }

        // Validation for user input
        public bool ValidateInput()
        {
            // Validate First Name
            string input = textBoxEmployeeFirstName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid First Name.", "Invalid");
                textBoxEmployeeFirstName.Clear();
                textBoxEmployeeFirstName.Focus();
                return false;
            }

            // Validate Last Name
            input = textBoxEmployeeLastName.Text.Trim();
            if (!Validator.IsValidName(input))
            {
                MessageBox.Show("Invalid Last Name.", "Invalid");
                textBoxEmployeeLastName.Clear();
                textBoxEmployeeLastName.Focus();
                return false;
            }

            // Validate Phone Number
            input = textBoxEmployeePhoneNumber.Text.Trim();
            if (!Validator.IsValidPhoneNumber(input))
            {
                MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeePhoneNumber.Clear();
                textBoxEmployeePhoneNumber.Focus();
                return false;
            }

            // Validate Email
            input = textBoxEmployeeEmail.Text.Trim();
            if (!Validator.IsValidEmail(input))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeEmail.Clear();
                textBoxEmployeeEmail.Focus();
                return false;
            }

            return true; // All validations passed
        }

        private void comboBoxSearchEmployeeOpton_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxSearchEmployeeOpton.SelectedIndex)
            {
                case 0:
                    labelSearchEmployee.Text = "Enter Employee Id";
                    break;
                case 1:
                    labelSearchEmployee.Text = "Enter First Name";
                    break;
                case 2:
                    labelSearchEmployee.Text = "Enter Last Name";
                    break;
                case 3:
                    labelSearchEmployee.Text = "Enter Email";
                    break;
                case 4:
                    labelSearchEmployee.Text = "Enter Phone Number";
                    break;
                case 5:
                    labelSearchEmployee.Text = "Enter Job Id";
                    break;
                case 6:
                    labelSearchEmployee.Text = "Enter Status Id";
                    break;
            }
        }
    }
}
