using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderServiceProject.Models;

namespace OrderServiceProject.Services
{
    public class OrderService
    {
        private SqlConnection _connection;
        public OrderService(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public List<Order> GetAll()
        {
            string sql = @"SELECT [Product].[NameProduct], [Product].[Price], [Order].[Id], [User].[Name],
                           [Order].[ProductId], [Order].[IsDeleted], [Product].[IsDeleted], [Order].[UserId], [Order].[OldPrice]
                           FROM [User] LEFT JOIN [Order] LEFT JOIN [Product]
                           ON [Order].[ProductId] = [Product].[Id]
                           ON [Order].[UserId] = [User].[Id]
                           WHERE [Order].[IsDeleted] = 'False'";

            List<Order> orderList = new List<Order>();
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Order data = new Order
                        {
                            Id = reader.GetInt32(2),
                            ProductId = reader.GetInt32(4),
                            IsDeleted = reader.GetBoolean(5),
                            UserId = reader.GetInt32(7),
                            Product = new Product
                            {
                                Id = reader.GetInt32(4),
                                NameProduct = reader.GetString(0),
                                Price = reader.GetInt32(1),
                                IsDeleted = reader.GetBoolean(6)
                            },
                            User = new User
                            {
                                Id = reader.GetInt32(7),
                                Name = reader.GetString(3)
                            },
                            OldPrice = reader.GetInt32(8)

                        };

                        orderList.Add(data);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return orderList;
        }

        public List<Order> GetOnlyClient(User user)
        {
            string sql = @"SELECT [Product].[NameProduct], [Product].[Price], [Order].[Id], [User].[Name],
                           [Order].[ProductId], [Order].[IsDeleted], [Product].[IsDeleted], [Order].[UserId], [Order].[OldPrice]
                           FROM [User] LEFT JOIN [Order] LEFT JOIN [Product]
                           ON [Order].[ProductId] = [Product].[Id]
                           ON [Order].[UserId] = [User].[Id]
                           WHERE [Order].[IsDeleted] = 'False'
                           AND [User].[Name] = @Name";

            List<Order> orderList = new List<Order>();
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);
                command.Parameters.AddWithValue("@Name", user.Name);


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order data = new Order
                        {
                            Id = reader.GetInt32(2),
                            ProductId = reader.GetInt32(4),
                            IsDeleted = reader.GetBoolean(5),
                            UserId = reader.GetInt32(7),
                            Product = new Product
                            {
                                Id = reader.GetInt32(4),
                                NameProduct = reader.GetString(0),
                                Price = reader.GetInt32(1),
                                IsDeleted = reader.GetBoolean(6)
                            },
                            User = new User
                            {
                                Id = reader.GetInt32(7),
                                Name = reader.GetString(3)
                            },
                            OldPrice = reader.GetInt32(8)

                        };

                        orderList.Add(data);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return orderList;
        }

        public void Delete(int id, Order data)
        {
            string sql = @"UPDATE [Order]
                           SET [IsDeleted] = @IsDeleted
                           WHERE [Id] = @Id";

            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("IsDeleted", data.IsDeleted = true);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        
    }
}
