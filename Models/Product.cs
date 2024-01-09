using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public int Quantity { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? LastModifiedAt { get; set; }
    }
}
