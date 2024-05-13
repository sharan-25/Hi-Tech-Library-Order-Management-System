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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

       private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(comboBoxUserEmployeeID.Text) || Validator.IsInputEmpty(textBoxUserPassword.Text.Trim()) || Validator.IsInputEmpty(comboBoxUserStatusID.Text))
            {
                MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Validate password
            string passwordInput = "";
            passwordInput = textBoxUserPassword.Text.Trim();
            if(!Validator.IsValidPassword(passwordInput))
            {
                MessageBox.Show("Password must be atleast 8 characters long and contain at least one uppercase letter, one lowercase letter, and one special character.", "Invalid Password");
                textBoxUserPassword.Clear();
                textBoxUserPassword.Focus();
                return;
            }
            /*//Validate Status ID
            string input = "";
            input = comboBoxUserStatusID.Text.Trim();
            if (!Validator.IsValid(input, 4))
            {
                MessageBox.Show("StatusId must be 4-digit number.", "Invalid Id");
                comboBoxUserStatusID.Text="";
                comboBoxUserStatusID.Focus();
                return;
            }
            //Validate Employee ID
            
            input = comboBoxUserEmployeeID.Text.Trim();
            if (!Validator.IsValid(input, 5))
            {
                MessageBox.Show("EmployeeId must be 5-digit number.", "Invalid Id");
                comboBoxUserEmployeeID.Text="";
                comboBoxUserEmployeeID.Focus();
                return;
            }*/

            User user = new User();
            //Save the valid data
            // Disable user ID textbox during save
            textBoxUserID.Enabled = false;
            user.Password = textBoxUserPassword.Text.Trim();
            //user.DateCreated = dateTimePickerUserDateCreated.Value;
            //user.DateModified = dateTimePickerUserDateModified.Value;
            user.StatusId = Convert.ToInt32(comboBoxUserStatusID.Text);
            user.EmployeeId = Convert.ToInt32(comboBoxUserEmployeeID.Text);
            user.SaveUser(user);
            // Enable user ID textbox after save
            textBoxUserID.Enabled = true;
            MessageBox.Show("Saved successfully!", "Confirmation");
            clearTextBox();
            textBoxUserID.Focus();



        }

        //Button Search
        private void Button_Search_Click(object sender, EventArgs e)
        
        {
            if (comboBoxSearchUserOpton.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Search option.", "Search Option",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User();
            List<User> listUser = new List<User>();
            switch (comboBoxSearchUserOpton.SelectedIndex)
            {

                case 0:


                    if (Validator.IsInputEmpty(textBoxUserSearch.Text.Trim()))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int userId;
                    if (!int.TryParse(textBoxUserSearch.Text, out userId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        return;
                    }
                    
                    user = user.SearchUser(Convert.ToInt32(textBoxUserSearch.Text));
                    if (user != null)
                    {
                        textBoxUserID.Text = user.UserId.ToString();
                        textBoxUserPassword.Text = user.Password.ToString();
                        comboBoxUserStatusID.Text = user.StatusId.ToString();
                        comboBoxUserEmployeeID.Text = user.EmployeeId.ToString();


                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Invalid UserId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        textBoxUserSearch.Focus();
                        return;
                    }
                    break;
                 case 1:
                    
                    if (Validator.IsInputEmpty(textBoxUserSearch.Text.Trim()))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int jobId;
                    if (!int.TryParse(textBoxUserSearch.Text, out jobId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        return;
                    }
                    
                    listUser = user.SearchUserbyId(Convert.ToInt32(textBoxUserSearch.Text));
                    if (listUser.Count != 0)
                    {
                        DisplayInfo(listUser, dataGridViewListUserData);
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Invalid UserId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        textBoxUserSearch.Focus();
                        return;
                    }
                    break;
                case 2:
                    if (Validator.IsInputEmpty(textBoxUserSearch.Text.Trim()))
                    {
                        MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // Parse the integer value
                    int employeeId;
                    if (!int.TryParse(textBoxUserSearch.Text, out employeeId))
                    {
                        MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        return;
                    }

                    listUser = user.SearchUserbyId(Convert.ToInt32(textBoxUserSearch.Text));
                    if (listUser.Count != 0)
                    {
                        DisplayInfo(listUser, dataGridViewListUserData);
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Invalid UserId", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserSearch.Clear();
                        textBoxUserSearch.Focus();
                        return;
                    }
                    break;



            }
        }

        //Update Button
        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(textBoxUserID.Text.Trim()))
            {
                MessageBox.Show("Input cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the integer value
            int userId;
            if (!int.TryParse(textBoxUserID.Text, out userId))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserSearch.Clear();
                return;
            }
            User user = new User();
           
            user.UserId = Convert.ToInt32(textBoxUserID.Text);
            //Validate password
            string passwordInput = "";
            passwordInput = textBoxUserPassword.Text.Trim();
            if (!Validator.IsValidPassword(passwordInput))
            {
                MessageBox.Show("Password must be atleast 8 characters long and contain at least one uppercase letter, one lowercase letter, and one special character.", "Invalid Password");
                textBoxUserPassword.Clear();
                textBoxUserPassword.Focus();
                return;
            }
            user.Password = textBoxUserPassword.Text;
            
            user.StatusId = Convert.ToInt32(comboBoxUserStatusID.Text);
            user.EmployeeId = Convert.ToInt32(comboBoxUserEmployeeID.Text); ;
           
            user.UpDateUser(user);
            MessageBox.Show("User data has been updated successfully.", "Confirmation");
            //clear textbox
            clearTextBox();
        }

        //Delete Button
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (Validator.IsInputEmpty(textBoxUserID.Text.Trim()))
            {
                MessageBox.Show("UserId cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Parse the integer value
            int userId;
            if (!int.TryParse(textBoxUserID.Text, out userId))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserSearch.Clear();
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                User user = new User();
                user.UserId = Convert.ToInt32(textBoxUserID.Text);
                user.DeleteUser(user);
                MessageBox.Show("User data has been deleted successfully!");
                textBoxUserID.Clear();
                textBoxUserID.Focus();
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }
        }

        //Button List All users
        private void Button_ListAll_Click(object sender, EventArgs e)
        {
            dataGridViewListUserData.Rows.Clear();
            User user = new User();

            List<User> listUser = user.GetAllUsers();

            DisplayInfo(listUser, dataGridViewListUserData);
        }
        // Display information
        private void DisplayInfo(List<User> listUser, DataGridView dataGridView)
        {
            // Clear existing rows and columns
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView.Columns.Add("UserId", "User ID");
            dataGridView.Columns.Add("Password", "Password");
            dataGridView.Columns.Add("DateCreated", "Date Created");
            dataGridView.Columns.Add("DateModified", "Date Modified");
            dataGridView.Columns.Add("StatusId", "Status ID");
            dataGridView.Columns.Add("EmployeeId", "Employee ID");

            if (listUser != null && listUser.Count > 0)
            {
                foreach (User user in listUser)
                {
                    dataGridView.Rows.Add(user.UserId, user.Password, user.DateCreated, user.DateModified, user.StatusId, user.EmployeeId);
                }
            }
            else
            {
                MessageBox.Show("No User in the database.", "Missing Data");
            }



        }
        public void clearTextBox()
        {
            // Clear textboxes
            textBoxUserID.Clear();
            textBoxUserPassword.Clear();
            comboBoxUserStatusID.Text="";
            comboBoxUserEmployeeID.Text = "";


        }

        //Button Close
        private void Button_Close_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to close the User Form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (answer == DialogResult.Yes)
            {
                this.Close();
                /*MainMenuForm form = new MainMenuForm();
                form.ShowDialog();
                this.Show();*/
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //Fetching the data of statusId from the database to show in combobox
            comboBoxUserStatusID.Items.Clear();

            using (SqlConnection connection = UtilityDB.ConnectDB())
            {
                string query = "SELECT StatusId FROM Status";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxUserStatusID.Items.Add(reader["StatusId"].ToString());
                }

                reader.Close();
            }
            //Fetching the data of employeeId from the database to show in combobox
            comboBoxUserEmployeeID.Items.Clear();

            using (SqlConnection connection = UtilityDB.ConnectDB())
            {
                string query = "SELECT EmployeeId FROM Employees";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxUserEmployeeID.Items.Add(reader["EmployeeId"].ToString());
                }

                reader.Close();
            }
        }

        //Combobox Employee
        private void comboBoxUserEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*// Check if an item is selected
            if (comboBoxUserEmployeeID.SelectedItem != null)
            {
                // Get the selected Employee ID
                int selectedEmployeeID = int.Parse(comboBoxUserEmployeeID.SelectedItem.ToString());

                // Check if the selected Employee ID exists for any User ID
                if (IsEmployeeIdAssigned(selectedEmployeeID))
                {
                    MessageBox.Show("This Employee ID is already assigned to another User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Reset the ComboBox selection
                    comboBoxUserEmployeeID.SelectedIndex = -1;
                }
            }*/

        }

        // Method to check if the Employee ID is already assigned to any User ID
        private bool IsEmployeeIdAssigned(int employeeId)
        {
            bool isAssigned = false;

            // Check if the Employee ID is already assigned to any User ID in the database
            using (SqlConnection connection = UtilityDB.ConnectDB())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE EmployeeID = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    isAssigned = true;
                }
            }

            return isAssigned;
        }

        private void comboBoxSearchUserOpton_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchUserOpton.SelectedIndex)
            {
                case 0:
                    labelSearchUser.Text = "Enter User Id";
                    break;
                case 1:
                    labelSearchUser.Text = "Enter Job Id";
                    break;
                case 2:
                    labelSearchUser.Text = "Enter Employee Id";
                    break;
                
            }
        }
    }
}
