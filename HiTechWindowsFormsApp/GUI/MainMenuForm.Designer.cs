namespace HiTechWindowsFormsApp.GUI
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ManageEmployee = new System.Windows.Forms.Button();
            this.button_ManageUser = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(291, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Employee Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Back  Miss Henry Brown!";
            // 
            // button_ManageEmployee
            // 
            this.button_ManageEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageEmployee.Location = new System.Drawing.Point(698, 368);
            this.button_ManageEmployee.Name = "button_ManageEmployee";
            this.button_ManageEmployee.Size = new System.Drawing.Size(241, 73);
            this.button_ManageEmployee.TabIndex = 2;
            this.button_ManageEmployee.Text = "Manage Employee";
            this.button_ManageEmployee.UseVisualStyleBackColor = false;
            this.button_ManageEmployee.Click += new System.EventHandler(this.button_ManageEmployee_Click);
            // 
            // button_ManageUser
            // 
            this.button_ManageUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageUser.Location = new System.Drawing.Point(449, 368);
            this.button_ManageUser.Name = "button_ManageUser";
            this.button_ManageUser.Size = new System.Drawing.Size(161, 73);
            this.button_ManageUser.TabIndex = 3;
            this.button_ManageUser.Text = "Manage User";
            this.button_ManageUser.UseVisualStyleBackColor = false;
            this.button_ManageUser.Click += new System.EventHandler(this.button_ManageUser_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(1011, 21);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(118, 54);
            this.button_Logout.TabIndex = 4;
            this.button_Logout.Text = "LogOut";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 585);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_ManageUser);
            this.Controls.Add(this.button_ManageEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ManageEmployee;
        private System.Windows.Forms.Button button_ManageUser;
        private System.Windows.Forms.Button button_Logout;
    }
}