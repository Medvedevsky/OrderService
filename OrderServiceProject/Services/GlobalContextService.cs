using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderServiceProject.Services
{
    public class GlobalContextService
    {
        public OrderService Order { get;}
        public ProductService Product { get;}
        public UserService User { get;}
        public AuthorizationService Authorization { get;}
        public GlobalContextService()
        {
            Order = new OrderService(ConnectionString());
            Product = new ProductService(ConnectionString());
            User = new UserService(ConnectionString());
            Authorization = new AuthorizationService(User);
        }

        private string ConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = @"ANDREYPC\SQLEXPRESS",
                InitialCatalog = "ProjectBD",
                IntegratedSecurity = true
            };

            return builder.ConnectionString;
        }
    }
}
