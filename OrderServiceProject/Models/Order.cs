using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public int OldPrice { get; set; }
        public Product Product { get; set; } 
        public User User { get; set; }
    }
}
