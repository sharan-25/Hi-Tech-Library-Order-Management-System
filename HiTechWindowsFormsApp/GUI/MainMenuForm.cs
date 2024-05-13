using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiTechWindowsFormsApp.GUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button_ManageUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm frm = new UserForm();
            frm.ShowDialog();
            this.Show();
        }

        private void button_ManageEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm frm = new EmployeeForm();
            frm.ShowDialog();
            this.Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (answer == DialogResult.Yes)
            {
                /*this.Hide();
                LogInForm form = new LogInForm();
                form.ShowDialog();
                this.Show();*/
                this.Close();

                

            }
            
           
        }
    }
}
