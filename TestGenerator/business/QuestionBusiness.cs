using System;
using System.Collections.Generic;
using TestGenerator.data.gateway;
using TestGenerator.data.model;

namespace TestGenerator.business
{
    class QuestionBusiness
    {
        private int question_id;
        private int test_id;
        private string data;

        public QuestionBusiness()
        {

        }

        public QuestionBusiness(int question_id, int test_id, string data)
        {
            this.Question_id = question_id;
            this.Test_id = test_id;
            this.Data = data;
        }

        public QuestionBusiness(int test_id)
        {
            this.Test_id = test_id;
        }

        public Boolean createQuestion()
        {
            QuestionDataModel newQuestionToCreate = new QuestionDataModel(this.question_id, this.test_id, this.data);
            QuestionDataGateway questionGateway = new QuestionDataGateway();
            return questionGateway.add(newQuestionToCreate);
        }

        public Boolean updateQuestion()
        {
            QuestionDataModel newQuestionToUpdate = new QuestionDataModel(this.question_id, this.test_id, this.data);
            QuestionDataGateway questionGateway = new QuestionDataGateway();
            return questionGateway.update(newQuestionToUpdate);
        }

        public Boolean deleteQuestion()
        {
            QuestionDataGateway questionGateway = new QuestionDataGateway();
            return questionGateway.delete(this.question_id);
        }

        public List<QuestionDataModel> getQuestions()
        {
            QuestionDataGateway questionGateway = new QuestionDataGateway();
            return questionGateway.read(this.test_id);
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
