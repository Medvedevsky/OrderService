using OrderServiceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OrderServiceProject.Services
{
    public class AuthorizationService
    {
        private UserService _service;
        public User Me { get; private set; }
        public AuthorizationService(UserService service)
        {
            _service = service;
        }

        public bool VerifyService(User user, string rawPassword)
        {
            if (user == null)
                return false;

            var bytes = Encoding.UTF8.GetBytes(rawPassword);
            var key = Encoding.UTF8.GetBytes("key");
            var h = new HMACSHA256(key);
            var hash = h.ComputeHash(bytes);
            var password = Convert.ToBase64String(hash);

            return user.Password == password;
        }

        public User SingIn(string login, string rawPassword)
        {
            Me = null;

            var user = _service.GetLoginFromUser(login);

            if(user != null && VerifyService(user, rawPassword))
            {
                Me = user;
                Me.Password = string.Empty;
            }

            return Me;
        }
    }
}
