using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjServiceAPI.Repository
{

    public class ConnectionRepo
    {
        protected string ConnectionString { get; set; }
        public ConnectionRepo()
        {
        }
        public ConnectionRepo(string connectionString)
        {
           
        }

    }
}
