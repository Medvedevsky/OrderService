using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderServiceProject.Models;

namespace OrderServiceProject.Services
{
    public class ProductService
    {
        private SqlConnection _connection;
        public ProductService(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public List<Product> GetAll()
        {
            string sql = @"SELECT * FROM [Product] WHERE [IsDeleted] = 'False'";
            List<Product> productList = new List<Product>();
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Product data = new Product
                        {
                            Id = reader.GetInt32(0),
                            NameProduct = reader.GetString(1),
                            Price = reader.GetInt32(2),
                            IsDeleted = reader.GetBoolean(3)
                        };

                        productList.Add(data);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return productList;
        }

        public void Add(Product data)
        {
            string sql = @"INSERT INTO [Product] ([NameProduct], [Price], [IsDeleted])
                           VALUES (@NameProduct, @Price, 'False')";

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@NameProduct", data.NameProduct);
                command.Parameters.AddWithValue("@Price", data.Price);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void ChangeData(int id, Product data)
        {
            string sql = @"UPDATE [Product]
                            SET [NameProduct] = @NameProduct, [Price] = @Price
                            WHERE [Id] = @Id";
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NameProduct", data.NameProduct);
                command.Parameters.AddWithValue("@Price", data.Price);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Delete(int id, Product data)
        {
            string sql = @"UPDATE [Product]
                            SET [IsDeleted] = @IsDeleted
                            WHERE [Id] = @Id";
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@IsDeleted", data.IsDeleted = true);
               

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void DoOrder(User user,Product data)
        {
            string sql = @"INSERT INTO [Order] ([ProductId], [UserId], [OldPrice], [IsDeleted])
                           VALUES (@ProductId, @UserId, @OldPrice, 'False')";

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@OldPrice", data.Price);
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@ProductId", data.Id);
                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
