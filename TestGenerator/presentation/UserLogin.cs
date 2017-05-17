using System;
using System.Windows.Forms;
using TestGenerator.business;

namespace TestGenerator.presentation
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            //load admin for debug
            FormAdmin FormAdmin = new FormAdmin();
            FormAdmin.Show();
            this.Hide();

        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            //Login the user...
        
            UserBusiness userToLoginBusiness = new UserBusiness((String) textBoxUserName.Text, (String) textBoxUserPassword.Text);

            if (userToLoginBusiness.login())

                //Show form by access level
                showFormByAccessLevel(userToLoginBusiness.Access_level);
            
            else
                MessageBox.Show("Invalid Login");
           

        }

        private void showFormByAccessLevel(Int16 access_level)
        {

            switch (access_level)
            {
                case 1:

                    FormAdmin FormAdmin = new FormAdmin();
                    FormAdmin.Show();
                    this.Hide();
                    break;

                case 2:

                    FormTeacher FormTeacher = new FormTeacher();
                    FormTeacher.Show();
                    this.Hide();
                   
                    break;

                case 3:

                    FormStudent FormStudent = new FormStudent();
                    FormStudent.Show();
                    this.Hide();
                                       break;
            }

        }

    }


   
}
