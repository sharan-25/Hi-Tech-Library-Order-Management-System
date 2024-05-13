using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Library.DAL;
using HiTechLibrary.DAL;
using HiTechLibrary.VALIDATION;
using HiTechWindowsFormsApp.GUI;

namespace HiTechWindowsFormsApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button_ConnectDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database is " + UtilityDB.ConnectDB().State.ToString());
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (!Validator.IsValid(textBoxLogInUserID.Text, 4))
            {
                MessageBox.Show("UserId must be a 4-digit number.", "Invalid Id");
                textBoxLogInUserID.Clear();
            }
            else if (!Validator.IsValidPassword(textBoxLogInPassword.Text))
            {
                MessageBox.Show("Password must be atleast 8 characters long and contain at least one uppercase letter, one lowercase letter, and one special character.", "Invalid Password");
                textBoxLogInPassword.Clear();
            }
            else
            {
                int userId = Convert.ToInt32(textBoxLogInUserID.Text);
                string password = textBoxLogInPassword.Text;

                string formName;

                if (LogInDB.VerifyLogin(userId, password, out formName))
                {
                    MessageBox.Show("Login successful!", "Success");
                    
                    // Open the form based on the determined form name
                    switch (formName)
                    {
                        case "MainMenuForm":
                            this.Hide();
                            MainMenuForm mainForm = new MainMenuForm();
                            
                            mainForm.ShowDialog();
                            this.Show();
                            textBoxLogInPassword.Clear();
                            textBoxLogInUserID.Clear();
                            break;
                        case "CustomerForm":
                            this.Hide();
                            CustomerForm customerForm = new CustomerForm();
                            customerForm.ShowDialog();
                            this.Show();
                            textBoxLogInPassword.Clear();
                            textBoxLogInUserID.Clear();
                            break;
                        case "BookForm":
                            this.Hide();
                            BookForm bookForm = new BookForm();
                            
                            bookForm.ShowDialog();
                            this.Show();
                            textBoxLogInPassword.Clear();
                            textBoxLogInUserID.Clear();
                            break;
                        case "OrdersForm":
                            this.Hide();
                            OrdersForm orderForm = new OrdersForm();
                            orderForm.ShowDialog();
                            this.Show();
                            textBoxLogInPassword.Clear();
                            textBoxLogInUserID.Clear();
                            break;
                        default:
                            
                            
                            break;
                    }
                    
                }
                
                else
                {
                    MessageBox.Show("Invalid login credentials. Please try again.", "Login Failed");
                    textBoxLogInPassword.Clear();
                    textBoxLogInUserID.Clear();
                }
            }

           



        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure , you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (answer == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

      
    }
}
