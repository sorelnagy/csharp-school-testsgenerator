using System;
using System.Collections.Generic;
using TestGenerator.data.gateway;
using TestGenerator.data.model;

namespace TestGenerator.business
{
    class RoleBusiness
    {
        private int role_id;
        private string role_name;

        public RoleBusiness(int role_id, String role_name)
        {
            this.Role_id = role_id;
            this.Role_name = role_name;
          
        }

        public RoleBusiness()
        {
    
        }

        public List<RolesDataModel> readAll()
        {

            RolesDataGateway rolesGateway = new RolesDataGateway();
            return rolesGateway.readAll();

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
