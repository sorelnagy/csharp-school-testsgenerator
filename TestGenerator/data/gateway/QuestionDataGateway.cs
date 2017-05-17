using DatabaseAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TestGenerator.data.model;

namespace TestGenerator.data.gateway
{
    class QuestionDataGateway
    {
        private DatabaseConnection connection;

        public QuestionDataGateway()
        {
            this.connection = new DatabaseConnection();
            this.connection.openConnection();
        }

        //Add a Question
        public Boolean add(QuestionDataModel question)
        {

            string query = "INSERT INTO questions (test_id, data) VALUES(@test_id,@data)";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@test_id", question.Test_id));
                cmd.Parameters.Add(new MySqlParameter("@data", question.Data));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;
            }

            return false;
        }

        //Get Question by Test_id
        public List<QuestionDataModel> read(int testId)
        {

            string query = "SELECT * FROM questions WHERE test_id = @test_id";
            List<QuestionDataModel> questionsList = new List<QuestionDataModel>();

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@user_id", testId));
                cmd.ExecuteNonQuery();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.Read().ToString());
                    questionsList.Add(new QuestionDataModel(Int32.Parse(dataReader["question_id"].ToString()), Int32.Parse(dataReader["test_id"].ToString()), dataReader["data"].ToString()));
                }

                this.connection.closeConnection();
            }

            return questionsList;
        }

        //Update a Question
        public Boolean update(QuestionDataModel question)
        {

            string query = "UPDATE questions SET test_id = @test_id, data = @data WHERE question_id = @question_id";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());

                cmd.Parameters.Add(new MySqlParameter("@test_id", question.Test_id));
                cmd.Parameters.Add(new MySqlParameter("@data", question.Data));
                cmd.Parameters.Add(new MySqlParameter("@question_id", question.Question_id));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;

            }
            return false;
        }

        //Delete a Question
        public Boolean delete(int questionId)
        {

            string query = "DELETE FROM tests WHERE question_id = @question_id";

            if (this.connection.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection.getConnection());
                cmd.Parameters.Add(new MySqlParameter("@question_id", questionId));

                cmd.ExecuteNonQuery();
                this.connection.closeConnection();

                return true;
            }
            return false;
        }


    }
}
