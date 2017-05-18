namespace TestGenerator.presentation
{
    partial class FormEditUser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.comboBoxUserAccessLevel = new System.Windows.Forms.ComboBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Access Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Display Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(133, 210);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(128, 46);
            this.buttonSaveUser.TabIndex = 13;
            this.buttonSaveUser.Text = "Save User Data";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // comboBoxUserAccessLevel
            // 
            this.comboBoxUserAccessLevel.FormattingEnabled = true;
            this.comboBoxUserAccessLevel.Location = new System.Drawing.Point(123, 172);
            this.comboBoxUserAccessLevel.Name = "comboBoxUserAccessLevel";
            this.comboBoxUserAccessLevel.Size = new System.Drawing.Size(184, 21);
            this.comboBoxUserAccessLevel.TabIndex = 12;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(123, 140);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.ReadOnly = true;
            this.textBoxUserPassword.Size = new System.Drawing.Size(184, 20);
            this.textBoxUserPassword.TabIndex = 11;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(123, 105);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(184, 20);
            this.textBoxDisplayName.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(123, 66);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(184, 20);
            this.textBoxUserName.TabIndex = 9;
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.Enabled = false;
            this.buttonGeneratePassword.Location = new System.Drawing.Point(375, 141);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(60, 22);
            this.buttonGeneratePassword.TabIndex = 18;
            this.buttonGeneratePassword.Text = "generate";
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "change";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 334);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonGeneratePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.comboBoxUserAccessLevel);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxDisplayName);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "FormEditUser";
            this.ShowIcon = false;
            this.Text = "Tests Generator | Admin Panel | Edit user";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.ComboBox comboBoxUserAccessLevel;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}