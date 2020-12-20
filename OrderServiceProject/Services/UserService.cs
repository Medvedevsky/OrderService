using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderServiceProject.Models;

namespace OrderServiceProject.Services
{
    public class UserService
    {
        private SqlConnection _connection;
        public UserService(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
        
        public User GetLoginFromUser(string login)
        {
            string sql = @"SELECT * FROM [User] WHERE [Login] = @Login";
            User user = null;

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Login", login);

                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        User data = new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Login = reader.GetString(2),
                            Password = reader.GetString(3),
                            Age = reader.GetDateTime(4),
                            Role = reader.GetString(5),
                            IsDeleted = reader.GetBoolean(6)
                        };
                        user = data;
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return user;
        }


        public List<User> GetAll()
        {
            string sql = @"SELECT*
                           FROM [User]
                           WHERE [Role] = 'client' AND [IsDeleted]= 'False'";
            List<User> userList = new List<User>();
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User data = new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Login = reader.GetString(2),
                            Password = reader.GetString(3),
                            Age = reader.GetDateTime(4),
                            Role = reader.GetString(5),
                            IsDeleted = reader.GetBoolean(6)
                        };

                        userList.Add(data);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return userList;
        }
        public void Add(User data)
        {
            string sql = @"INSERT INTO [User] ([Name],[Login], [Password],  [Age], [Role], [IsDeleted])
                           VALUES (@Name,  @Login, @Password, @Age, @Role, 'False')";

            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Name", data.Name);
                command.Parameters.AddWithValue("@Login", data.Login);
                command.Parameters.AddWithValue("@Password", data.Password);
                command.Parameters.AddWithValue("@Age", data.Age);
                command.Parameters.AddWithValue("@Role", data.Role);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void ChangeData(int id, User data)
        {
            string sql = @"UPDATE [User]
                            SET [Name] = @Name, [Login]= @Login, [Password] = @Password, [Age] = @Age, [Role] = @Role
                            WHERE [Id] = @Id";
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", data.Name);
                command.Parameters.AddWithValue("@Login", data.Login);
                command.Parameters.AddWithValue("@Password", data.Password);
                command.Parameters.AddWithValue("@Age", data.Age);
                command.Parameters.AddWithValue("@Role", data.Role);

                command.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Delete(int id, User data)
        {
            string sql = @"UPDATE [User]
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
    }
}
