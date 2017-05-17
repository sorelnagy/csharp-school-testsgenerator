using System;
using TestGenerator.data.model;
using TestGenerator.DataAccessLayer;
using TestGenerator.data.util;
using System.Collections.Generic;

namespace TestGenerator.business
{
    class UserBusiness
    {
        private int user_id;
        private string username;
        private string password;
        private string display_name;
        private Int16 access_level;


        public UserBusiness()
        {
      
        }

        public UserBusiness(int user_id, String username, String password, Int16 access_level)
        {
            this.User_id = user_id;
            this.Username = username;
            this.Password = UserSecurity.hashPassword(password);
            this.Access_level = access_level;
        }

        public UserBusiness(String username, String password, String display_name, Int16 access_level)
        {
                       this.Username = username;
            this.Password = UserSecurity.hashPassword(password);
            this.Display_name = display_name;
            this.Access_level = access_level;
        }

        public UserBusiness(int user_id)
        {
          this.User_id = user_id;
        }


        public UserBusiness(String username, String password, Int16 access_level)
        {
         
            this.Username = username;
            this.Password = UserSecurity.hashPassword(password);
            this.Access_level = access_level;
        }

        public UserBusiness(String username, String password)
        {
          
            this.Username = username;
            this.Password = UserSecurity.hashPassword(password);
        }

        public UserBusiness(String username)
        {
           
            this.Username = username;
        }


        public Boolean createUser()
        {


            UserDataModel newUserToCreate = new UserDataModel(this.Username, this.Password, this.Display_name, this.Access_level);
            UserDataGateway userGateway = new UserDataGateway();


            //Check if user exists
            if (userGateway.read(this.Username) == null)
            {
                return userGateway.add(newUserToCreate);
            }

            return false;
            

       }

        public Boolean updateUser()
        {
            UserDataModel userToUpdate = new UserDataModel(this.Username, this.Password, this.Display_name, this.Access_level);

            UserDataGateway userGateway = new UserDataGateway();
            return userGateway.update(userToUpdate);
        }

        public Boolean deleteUser()
        {

            UserDataGateway userGateway = new UserDataGateway();
            return userGateway.delete(this.User_id);

        }


        public UserBusiness viewUser()
        {
            UserDataGateway userGateway = new UserDataGateway();
            UserDataModel userToView = userGateway.read(this.Username);

            if(userToView != null)
            {
                this.User_id = userToView.User_id;
                this.Password = userToView.Password;
                this.Display_name = userToView.Display_name;
                this.Access_level = (Int16) userToView.Access_level;
                return this;
            }

            return null;

        }

        public Boolean login()
        {
            UserDataGateway userGateway = new UserDataGateway();
            UserDataModel userToLogin = userGateway.read(this.Username);

            Console.WriteLine(this.Password);
            
            if(userToLogin != null)
            {
                if(this.Username.Equals(userToLogin.Username) && this.Password.Equals(userToLogin.Password))
                {
                    this.User_id = userToLogin.User_id;
                    this.Display_name = userToLogin.Display_name;
                    this.Access_level = (Int16) userToLogin.Access_level;

                    return true;
                }
            }

            return false;
        }

        
        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Display_name
        {
            get
            {
                return display_name;
            }

            set
            {
                display_name = value;
            }
        }

        public short Access_level
        {
            get
            {
                return access_level;
            }

            set
            {
                access_level = value;
            }
        }


    }
}
