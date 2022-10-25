using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Balogh_David_Lab2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Column(TypeName = "text")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Adress { get; set; }

        public DateTime BirthDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}