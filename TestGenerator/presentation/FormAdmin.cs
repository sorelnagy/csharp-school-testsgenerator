using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TestGenerator.business;
using TestGenerator.data.model;
using TestGenerator.DataAccessLayer;
using static System.Windows.Forms.ListViewItem;

namespace TestGenerator.presentation
{
    public partial class FormAdmin : Form
    {



        public FormAdmin()
        {
            InitializeComponent();
           

        }



        public void FormAdmin_Load(object sender, EventArgs e)
        {

            populateRolesComboBox();
            populateUsersList();

            textBoxSearchUser.Text = "Search user ...";
        }


        private void FormAdmin_Activated(object sender, EventArgs e)
        {
            populateUsersList();
        }

        private void populateRolesComboBox()
        {

            //Get the roles for add a new user ...
            RoleBusiness userRoles = new RoleBusiness();
            List<RolesDataModel> usersRolesList = userRoles.readAll();

            //Set the display member and value memebr / admin = 1
            comboBoxUserRoles.DisplayMember = "Text";
            comboBoxUserRoles.ValueMember = "Value";

            List<ComboboxItem> list = new List<ComboboxItem>();
            ComboboxItem item = new ComboboxItem();

            for (var i = 0; i < usersRolesList.Count; i++)
            {
                item = new ComboboxItem();
                item.Text = usersRolesList[i].Role_name;
                item.Value = usersRolesList[i].Role_id;
                list.Add(item);
           }

            comboBoxUserRoles.DataSource = list; // Bind combobox to a datasource
        }

    
        private void populateUsersList()
        {

            listViewUsers.Clear();

            //Get all users
            UserBusiness userBusiness = new UserBusiness();
            

            UserDataGateway userGateway = new UserDataGateway();


            List<UserDataModel> usersToShow = userGateway.readAll();

            //preapre list view
            listViewUsers.Items.Clear();
            listViewUsers.View = View.Details;

            listViewUsers.Columns.Add("Display Name", 350);
            listViewUsers.Columns.Add("Username", 180);
            listViewUsers.Columns.Add("User Type", 120);

            foreach (UserDataModel user in usersToShow)
            {

                ListViewItem item = new ListViewItem();

                item.Text = user.Display_name.ToString();
                item.Name = user.Username.ToString();
                item.SubItems.Add(user.Username.ToString());
                item.SubItems.Add(user.Role_name.ToString());

                listViewUsers.Items.Add(item);
                

             }

        }

        private void populateUsersList(List<UserDataModel> usersList)
        {

            listViewUsers.Clear();

            //preapre list view
            listViewUsers.Items.Clear();
            listViewUsers.View = View.Details;

            listViewUsers.Columns.Add("Display Name", 350);
            listViewUsers.Columns.Add("Username", 180);
            listViewUsers.Columns.Add("User Type", 120);

            foreach (UserDataModel user in usersList)
            {

                ListViewItem item = new ListViewItem();

                item.Text = user.Display_name.ToString();
                item.Name = user.Username.ToString();
                item.SubItems.Add(user.Username.ToString());
                item.SubItems.Add(user.Role_name.ToString());

                listViewUsers.Items.Add(item);


            }

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            //Check the role

            RoleBusiness userRoles = new RoleBusiness();
            List<RolesDataModel> usersRolesList = userRoles.readAll();

            UserBusiness userToAdd = new UserBusiness(textBoxUserName.Text, textBoxUserPassword.Text, textBoxUserDisplayName.Text, Int16.Parse(comboBoxUserRoles.SelectedValue.ToString()));

            //Show buttons
            uiAddingUser();

            if (userToAdd.createUser())
            {
                labelCreateUserMessage.Text = "User created.";

                //Populate the suers list
                populateUsersList();
            }
            else
            {
                labelCreateUserMessage.Text = "User already exists.";
            }
        }

        private void uiAddingUser()
        {

            //Preapre the label
            labelCreateUserMessage.Visible = true;

            //Preapre the clear button
            buttonClearForm.Visible = true;

        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxUserDisplayName.Text = "";
            textBoxUserName.Text = "";
            textBoxUserPassword.Text = "";

            buttonClearForm.Visible = false;

            labelCreateUserMessage.Visible = false;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

            if (listViewUsers.SelectedItems.Count > 0)
            {

                ListViewItem item = listViewUsers.SelectedItems[0];

                //Delete this user by username
                UserBusiness userBusiness = new UserBusiness(item.Name.ToString());

                if (userBusiness.deleteUserByUsername())
                {
                    MessageBox.Show("User Deleted");
                    populateUsersList();
                }
                else
                {
                    MessageBox.Show("An error has occurred");
                }
            }else
            {
                MessageBox.Show("Please select a user");
            }



        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                FormEditUser formToEdit = new FormEditUser(item.Name.ToString(), this);
                formToEdit.Show();
            }
            catch (Exception ex) {
                MessageBox.Show("Select a user");
            }
         

        }


        //TextBox Search
        private void textBoxSearchUser_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchUser.Text == "Search user ...")
            {
                textBoxSearchUser.Text = "";
            }
        }

        private void textBoxSearchUser_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchUser.Text == "")
            {
                textBoxSearchUser.Text = "Search user ...";
                textBoxSearchUser.ForeColor = System.Drawing.Color.Gray;
                populateUsersList();
            }
                      
        }

        private void textBoxSearchUser_TextChanged(object sender, EventArgs e)
        {

         
                String currentString = textBoxSearchUser.Text;
                UserBusiness userBusiness = new UserBusiness(currentString);

                  if (currentString.Length >= 2)
                {
                    Console.WriteLine(userBusiness.search().Count);
                    populateUsersList(userBusiness.search());

                }

            if (currentString.Length == 0)
            {
                populateUsersList();
            }
        }
   }

  

}
