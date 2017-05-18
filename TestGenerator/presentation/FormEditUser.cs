using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestGenerator.business;
using TestGenerator.data.model;

namespace TestGenerator.presentation
{
    public partial class FormEditUser : Form
    {

        UserBusiness userBusiness;
        Form FormAdmin;

        public FormEditUser(String username, Form adminForm)
        {

            InitializeComponent();


            //Get the user
           
            userBusiness = new UserBusiness(username);

            userBusiness.viewUser();

            textBoxUserName.Text = userBusiness.Username;
            textBoxDisplayName.Text = userBusiness.Display_name;

            textBoxUserPassword.PasswordChar = '*';
            textBoxUserPassword.Text = userBusiness.Password;

            FormAdmin = adminForm;


       }

        public void FormEditUser_Load(object sender, EventArgs e)
        {

            populateRolesComboBox();
            
            //Selected current user role
            comboBoxUserAccessLevel.SelectedIndex = comboBoxUserAccessLevel.FindStringExact(userBusiness.Role_name);
        }


        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            textBoxUserPassword.Text =  new string(Enumerable.Repeat(chars, 16)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (!checkBox1.Checked)
            {
                checkBox1.ThreeState = true;
                textBoxUserPassword.Text = userBusiness.Password;
                textBoxUserPassword.PasswordChar = '*';
                textBoxUserPassword.ReadOnly = true;
                buttonGeneratePassword.Enabled = false;
            }
            else
            {
                checkBox1.ThreeState = false;
                textBoxUserPassword.Text = "";
                textBoxUserPassword.PasswordChar = '\0';
                textBoxUserPassword.ReadOnly = false;
                buttonGeneratePassword.Enabled = true;
            }

            

        }


        private void populateRolesComboBox()
        {

            //Get the roles for add a new user ...
            RoleBusiness userRoles = new RoleBusiness();
            List<RolesDataModel> usersRolesList = userRoles.readAll();

            //Set the display member and value memebr / admin = 1
            comboBoxUserAccessLevel.DisplayMember = "Text";
            comboBoxUserAccessLevel.ValueMember = "Value";

            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item = new ComboboxItem();

            for (var i = 0; i < usersRolesList.Count; i++)
            {
                item = new ComboboxItem();
                item.Text = usersRolesList[i].Role_name;
                item.Value = usersRolesList[i].Role_id;
                list.Add(item);
            }

            comboBoxUserAccessLevel.DataSource = list; // Bind combobox to a datasource


        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            userBusiness.Display_name = textBoxDisplayName.Text;

            if(checkBox1.Checked)
                userBusiness.Password = textBoxUserPassword.Text;

            userBusiness.Access_level = Int16.Parse(comboBoxUserAccessLevel.SelectedValue.ToString());
            
            if (userBusiness.updateUser())
            {
                MessageBox.Show("User Updated");
                
                //Refresh the form
                FormAdmin.Focus();

            }
            else
            {
                MessageBox.Show("An error has occurred");
            }

        }
    }
}
