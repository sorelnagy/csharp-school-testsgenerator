using DatabaseAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TestGenerator.data.model;

namespace TestGenerator.data.gateway
{
    class TestDataGateway
    {

        private DatabaseConnection connection;

        public TestDataGateway()
        {
            this.connection = new DatabaseConnection();
            this.connection.openConnection();
        }

        //Add a Test
        public Boolean add(TestDataModel test)
        {

            string query = "INSERT INTO tests (user_id, test_name, category, timer, public, display) VALUES(@user_id,@test_name,@category,@timer,@public,@display)";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@user_id", test.User_id));
                cmd.Parameters.Add(new MySqlParameter("@test_name", test.Test_name));
                cmd.Parameters.Add(new MySqlParameter("@category", test.Category));
                cmd.Parameters.Add(new MySqlParameter("@timer", test.Timer));
                cmd.Parameters.Add(new MySqlParameter("@public", test.IsPublic));
                cmd.Parameters.Add(new MySqlParameter("@display", test.Display));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;
            }

            return false;
        }

        //Get Test by the User_id
        public TestDataModel read(int userId)
        {

            string query = "SELECT * FROM tests WHERE user_id = @user_id";
            TestDataModel newTest = null;

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@user_id", userId));
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    newTest = new TestDataModel(Int32.Parse(dataReader["test_id"].ToString()), Int32.Parse(dataReader["user_id"].ToString()), dataReader["test_name"].ToString(), dataReader["category"].ToString(), Int32.Parse(dataReader["timer"].ToString()), Int32.Parse(dataReader["public"].ToString()), Int32.Parse(dataReader["display"].ToString()));
                    Console.WriteLine(newTest.Test_name.ToString());
                }

                this.connection.closeConnection();
            }

            return newTest;
        }

        //Get Tests by Test_name;
        public List<TestDataModel> search(string testName)
        {

            string query = "SELECT * FROM tests WHERE test_name like '%@test_name%'"; //like
            List<TestDataModel> testsList = new List<TestDataModel>();

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@test_name", testName));
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    testsList.Add(new TestDataModel(Int32.Parse(dataReader["test_id"].ToString()), Int32.Parse(dataReader["user_id"].ToString()), dataReader["test_name"].ToString(), dataReader["category"].ToString(), Int32.Parse(dataReader["timer"].ToString()), Int32.Parse(dataReader["public"].ToString()), Int32.Parse(dataReader["display"].ToString())));
                    Console.WriteLine(dataReader.Read().ToString());
                }

                this.connection.closeConnection();
            }

            return testsList;
        }

        //Lists all the Tests
        public List<TestDataModel> readAll()
        {

            string query = "SELECT * FROM tests";
            List<TestDataModel> testsList = new List<TestDataModel>();


            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.Read().ToString());
                    testsList.Add(new TestDataModel(Int32.Parse(dataReader["test_id"].ToString()), Int32.Parse(dataReader["user_id"].ToString()), dataReader["test_name"].ToString(), dataReader["category"].ToString(), Int32.Parse(dataReader["timer"].ToString()), Int32.Parse(dataReader["public"].ToString()), Int32.Parse(dataReader["display"].ToString())));
                }

                this.connection.closeConnection();
            }
            return testsList;
        }

        //Update a Test
        public Boolean update(TestDataModel test)
        {

            string query = "UPDATE tests SET user_id = @user_id, test_name = @test_name, category = @category, timer = @timer, public = @public, display = @display, WHERE test_id = @test_id";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@user_id", test.User_id));
                cmd.Parameters.Add(new MySqlParameter("@test_name", test.Test_name));
                cmd.Parameters.Add(new MySqlParameter("@category", test.Category));
                cmd.Parameters.Add(new MySqlParameter("@timer", test.Timer));
                cmd.Parameters.Add(new MySqlParameter("@public", test.IsPublic));
                cmd.Parameters.Add(new MySqlParameter("@display", test.Display));
                cmd.Parameters.Add(new MySqlParameter("@test_id", test.Test_id));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;

            }

            return false;

        }

        //Delete a Test
        public Boolean delete(int testId)
        {

            string query = "DELETE FROM tests WHERE test_id = @test_id";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());
                cmd.Parameters.Add(new MySqlParameter("@test_id", testId));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;

            }

            return false;

        }

    }
}
