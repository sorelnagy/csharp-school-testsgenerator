using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGenerator.data.model;
using TestGenerator.data.gateway;

namespace TestGenerator.business
{
    class TestBusiness
    {
        private int test_id;
        private int user_id;
        private string test_name;
        private string category;
        private int timer;
        private int isPublic;
        private int display;

        public TestBusiness()
        {

        }

        public TestBusiness(int test_id, int user_id, string test_name, string category, int timer, int isPublic, int display)
        {
            this.Test_id = test_id;
            this.User_id = user_id;
            this.Test_name = test_name;
            this.Category = category;
            this.Timer = timer;
            this.IsPublic = isPublic;
            this.Display = display;

        }

        public TestBusiness(int user_id)
        {
            this.User_id = user_id;
        }

        public TestBusiness(string test_name)
        {
            this.Test_name = test_name;
        }

        public Boolean createTest()
        {
            TestDataModel newTestToCreate = new TestDataModel(this.user_id, this.test_name, this.category, this.timer, this.isPublic, this.display);
            TestDataGateway testGateway = new TestDataGateway();

            return testGateway.add(newTestToCreate);
        }


        public Boolean updateTest()
        {
            TestDataModel newTestToUpdate = new TestDataModel(this.user_id, this.test_name, this.category, this.timer, this.isPublic, this.display);
            TestDataGateway testGateway = new TestDataGateway();
            return testGateway.update(newTestToUpdate);
        }

        public Boolean deleteTest()
        {
            TestDataGateway testGateway = new TestDataGateway();
            return testGateway.delete(this.test_id);
        }

        public List<TestDataModel> viewAllTests()
        {
            TestDataGateway testGateway = new TestDataGateway();
            return testGateway.readAll();
        }

        public TestBusiness viewTestByUserId()
        {
            TestDataGateway testGateway = new TestDataGateway();
            TestDataModel testToView = testGateway.read(this.user_id);
            if(testToView != null)
            {
                this.Test_id = test_id;
                this.Test_name = test_name;
                this.Category = category;
                this.Timer = timer;
                this.IsPublic = isPublic;
                this.Display = display;
                return this;
            }
            return null;
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

        public string Test_name
        {
            get
            {
                return test_name;
            }

            set
            {
                test_name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public int Timer
        {
            get
            {
                return timer;
            }

            set
            {
                timer = value;
            }
        }

        public int IsPublic
        {
            get
            {
                return isPublic;
            }

            set
            {
                isPublic = value;
            }
        }

        public int Display
        {
            get
            {
                return display;
            }

            set
            {
                display = value;
            }
        }

       
    }
}
