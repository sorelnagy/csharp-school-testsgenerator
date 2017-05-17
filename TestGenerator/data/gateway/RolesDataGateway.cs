using DatabaseAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TestGenerator.data.model;

namespace TestGenerator.data.gateway
{
    class RolesDataGateway
    {


        private DatabaseConnection connection;


        public RolesDataGateway()
        {
            this.connection = new DatabaseConnection();
            this.connection.openConnection();
        }


        //Lists all the users
        public List<RolesDataModel> readAll()
        {

            string query = "SELECT * FROM user_roles";
            List<RolesDataModel> rolesList = new List<RolesDataModel>();


            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    rolesList.Add(new RolesDataModel(Int32.Parse(dataReader["role_id"].ToString()), dataReader["role_name"].ToString()));
                }

                this.connection.closeConnection();
            }

            return rolesList;

        }

    }
}
