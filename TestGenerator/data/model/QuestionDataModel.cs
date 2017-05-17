using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.data.model
{
    class QuestionDataModel
    {

        private int question_id;
        private int test_id;
        private string data;

        //COMMENT ADDED HERE

        //COMMENT ADDED HERE

        //COMMENT ADDED HERE

        //COMMENT ADDED HERE
////////


            //asddddddddd//asdasdasda
        //COMMENT ADDED HERE
        public QuestionDataModel(int question_id, int test_id, string data)
        {
            this.question_id = question_id;
            this.test_id = test_id;
            this.data = data;
        }

        public int Question_id
        {
            get
            {
                return question_id;
            }

            set
            {
                question_id = value;
            }
        }

        public int Test_id
        {
            get
            {
                return test_id;
            }

            set
            {
                test_id = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

    }
}
