namespace HiTechWindowsFormsApp.GUI
{
    partial class UserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxUserStatusID = new System.Windows.Forms.ComboBox();
            this.comboBoxUserEmployeeID = new System.Windows.Forms.ComboBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_ListAll = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.dataGridViewListUserData = new System.Windows.Forms.DataGridView();
            this.textBoxUserSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSearchUserOpton = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSearchUser = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUserData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBoxUserStatusID);
            this.groupBox1.Controls.Add(this.comboBoxUserEmployeeID);
            this.groupBox1.Controls.Add(this.textBoxUserPassword);
            this.groupBox1.Controls.Add(this.textBoxUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(94, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Employee@12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(171, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "4 digits";
            // 
            // comboBoxUserStatusID
            // 
            this.comboBoxUserStatusID.FormattingEnabled = true;
            this.comboBoxUserStatusID.Location = new System.Drawing.Point(174, 215);
            this.comboBoxUserStatusID.Name = "comboBoxUserStatusID";
            this.comboBoxUserStatusID.Size = new System.Drawing.Size(138, 26);
            this.comboBoxUserStatusID.TabIndex = 11;
            // 
            // comboBoxUserEmployeeID
            // 
            this.comboBoxUserEmployeeID.FormattingEnabled = true;
            this.comboBoxUserEmployeeID.Location = new System.Drawing.Point(174, 156);
            this.comboBoxUserEmployeeID.Name = "comboBoxUserEmployeeID";
            this.comboBoxUserEmployeeID.Size = new System.Drawing.Size(138, 26);
            this.comboBoxUserEmployeeID.TabIndex = 10;
            this.comboBoxUserEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserEmployeeID_SelectedIndexChanged);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(174, 98);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(138, 24);
            this.textBoxUserPassword.TabIndex = 7;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(174, 47);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(138, 24);
            this.textBoxUserID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.Location = new System.Drawing.Point(890, 19);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(108, 43);
            this.Button_Close.TabIndex = 26;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_ListAll
            // 
            this.Button_ListAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Button_ListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ListAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_ListAll.Location = new System.Drawing.Point(550, 421);
            this.Button_ListAll.Name = "Button_ListAll";
            this.Button_ListAll.Size = new System.Drawing.Size(108, 43);
            this.Button_ListAll.TabIndex = 25;
            this.Button_ListAll.Text = "List All";
            this.Button_ListAll.UseVisualStyleBackColor = false;
            this.Button_ListAll.Click += new System.EventHandler(this.Button_ListAll_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Search.Location = new System.Drawing.Point(50, 186);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(108, 43);
            this.Button_Search.TabIndex = 24;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = false;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Delete.Location = new System.Drawing.Point(405, 421);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(108, 43);
            this.Button_Delete.TabIndex = 23;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Update.Location = new System.Drawing.Point(255, 421);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(108, 43);
            this.Button_Update.TabIndex = 22;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Save.Location = new System.Drawing.Point(109, 421);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(108, 43);
            this.Button_Save.TabIndex = 21;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // dataGridViewListUserData
            // 
            this.dataGridViewListUserData.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewListUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListUserData.Location = new System.Drawing.Point(109, 490);
            this.dataGridViewListUserData.Name = "dataGridViewListUserData";
            this.dataGridViewListUserData.RowHeadersWidth = 51;
            this.dataGridViewListUserData.RowTemplate.Height = 24;
            this.dataGridViewListUserData.Size = new System.Drawing.Size(580, 141);
            this.dataGridViewListUserData.TabIndex = 27;
            // 
            // textBoxUserSearch
            // 
            this.textBoxUserSearch.Location = new System.Drawing.Point(32, 146);
            this.textBoxUserSearch.Name = "textBoxUserSearch";
            this.textBoxUserSearch.Size = new System.Drawing.Size(138, 24);
            this.textBoxUserSearch.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.comboBoxSearchUserOpton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelSearchUser);
            this.groupBox2.Controls.Add(this.textBoxUserSearch);
            this.groupBox2.Controls.Add(this.Button_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(630, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 258);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search User";
            // 
            // comboBoxSearchUserOpton
            // 
            this.comboBoxSearchUserOpton.FormattingEnabled = true;
            this.comboBoxSearchUserOpton.Items.AddRange(new object[] {
            "UserId",
            "Employee Id",
            "StatusId"});
            this.comboBoxSearchUserOpton.Location = new System.Drawing.Point(32, 67);
            this.comboBoxSearchUserOpton.Name = "comboBoxSearchUserOpton";
            this.comboBoxSearchUserOpton.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchUserOpton.TabIndex = 34;
            this.comboBoxSearchUserOpton.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchUserOpton_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Select Search Option";
            // 
            // labelSearchUser
            // 
            this.labelSearchUser.AutoSize = true;
            this.labelSearchUser.Location = new System.Drawing.Point(29, 110);
            this.labelSearchUser.Name = "labelSearchUser";
            this.labelSearchUser.Size = new System.Drawing.Size(85, 18);
            this.labelSearchUser.TabIndex = 29;
            this.labelSearchUser.Text = "Enter data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "User Management System";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::HiTechWindowsFormsApp.Properties.Resources.U__8_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 737);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewListUserData);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_ListAll);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListUserData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_ListAll;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.DataGridView dataGridViewListUserData;
        private System.Windows.Forms.TextBox textBoxUserSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSearchUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxUserStatusID;
        private System.Windows.Forms.ComboBox comboBoxUserEmployeeID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSearchUserOpton;
    }
}