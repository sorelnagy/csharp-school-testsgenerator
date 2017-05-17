using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.data.model
{
    class TestDataModel
    {

        private int test_id;
        private int user_id;
        private string test_name;
        private string category;
        private int timer;
        private int isPublic;
        private int display;

        public TestDataModel(int test_id, int user_id, string test_name, string category, int timer, int isPublic, int display)
        {
            this.test_id = test_id;
            this.user_id = user_id;
            this.test_name = test_name;
            this.category = category;
            this.timer = timer;
            this.isPublic = isPublic;
            this.display = display;
        }

        public TestDataModel(int user_id, string test_name, string category, int timer, int isPublic, int display)
        {
            this.user_id = user_id;
            this.test_name = test_name;
            this.category = category;
            this.timer = timer;
            this.isPublic = isPublic;
            this.display = display;
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
