using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
