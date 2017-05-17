using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.data.model
{
    class RolesDataModel
    {
        private int role_id;
        private String role_name;
       
        public RolesDataModel(int role_id, String role_name)
        {
            this.Role_id = role_id;
            this.Role_name = role_name;
        }

        public int Role_id
        {
            get
            {
                return role_id;
            }

            set
            {
                role_id = value;
            }
        }

        public string Role_name
        {
            get
            {
                return role_name;
            }

            set
            {
                role_name = value;
            }
        }
    }
}
