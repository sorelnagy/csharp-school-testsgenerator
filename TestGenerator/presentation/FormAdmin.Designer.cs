using System;

namespace TestGenerator.presentation
{
    partial class FormAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClearForm = new MetroFramework.Controls.MetroButton();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new MetroFramework.Controls.MetroButton();
            this.labelCreateUserMessage = new System.Windows.Forms.Label();
            this.comboBoxUserRoles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserDisplayName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonClearForm);
            this.tabPage1.Controls.Add(this.textBoxUserName);
            this.tabPage1.Controls.Add(this.buttonAddUser);
            this.tabPage1.Controls.Add(this.labelCreateUserMessage);
            this.tabPage1.Controls.Add(this.comboBoxUserRoles);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxUserPassword);
            this.tabPage1.Controls.Add(this.textBoxUserDisplayName);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New User";
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Location = new System.Drawing.Point(374, 282);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(133, 45);
            this.buttonClearForm.TabIndex = 13;
            this.buttonClearForm.Text = "Add a New One";
            this.buttonClearForm.UseSelectable = true;
            this.buttonClearForm.Visible = false;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(310, 58);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(197, 26);
            this.textBoxUserName.TabIndex = 12;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(193, 282);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(165, 45);
            this.buttonAddUser.TabIndex = 10;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseSelectable = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelCreateUserMessage
            // 
            this.labelCreateUserMessage.AutoSize = true;
            this.labelCreateUserMessage.Location = new System.Drawing.Point(276, 354);
            this.labelCreateUserMessage.Name = "labelCreateUserMessage";
            this.labelCreateUserMessage.Size = new System.Drawing.Size(189, 20);
            this.labelCreateUserMessage.TabIndex = 9;
            this.labelCreateUserMessage.Text = "labelCreateUserMessage";
            this.labelCreateUserMessage.Visible = false;
            // 
            // comboBoxUserRoles
            // 
            this.comboBoxUserRoles.FormattingEnabled = true;
            this.comboBoxUserRoles.Location = new System.Drawing.Point(310, 214);
            this.comboBoxUserRoles.Name = "comboBoxUserRoles";
            this.comboBoxUserRoles.Size = new System.Drawing.Size(197, 28);
            this.comboBoxUserRoles.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Display Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(310, 159);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(197, 26);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // textBoxUserDisplayName
            // 
            this.textBoxUserDisplayName.Location = new System.Drawing.Point(310, 111);
            this.textBoxUserDisplayName.Name = "textBoxUserDisplayName";
            this.textBoxUserDisplayName.Size = new System.Drawing.Size(197, 26);
            this.textBoxUserDisplayName.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textBoxSearchUser);
            this.tabPage2.Controls.Add(this.buttonEditUser);
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.listViewUsers);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Users";
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Location = new System.Drawing.Point(455, 29);
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(213, 26);
            this.textBoxSearchUser.TabIndex = 6;
            this.textBoxSearchUser.TextChanged += new System.EventHandler(this.textBoxSearchUser_TextChanged);
            this.textBoxSearchUser.Enter += new System.EventHandler(this.textBoxSearchUser_Enter);
            this.textBoxSearchUser.Leave += new System.EventHandler(this.textBoxSearchUser_Leave);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(11, 359);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(137, 45);
            this.buttonEditUser.TabIndex = 5;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Maroon;
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(531, 359);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(137, 45);
            this.buttonDeleteUser.TabIndex = 4;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.AllowColumnReorder = true;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(11, 61);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(657, 271);
            this.listViewUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUsers.TabIndex = 2;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "List Of All Users";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 504);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin";
            this.Text = "Test Generator - Admin Panel";
            this.Activated += new System.EventHandler(this.FormAdmin_Activated);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxUserRoles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCreateUserMessage;
        private MetroFramework.Controls.MetroButton buttonAddUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserDisplayName;
        private MetroFramework.Controls.MetroButton buttonClearForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.TextBox textBoxSearchUser;
    }
}