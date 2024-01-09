using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Models
{
    public class OrderQuantity
    {
        public Guid Item { get; set; }

        public int Quantity { get; set; }

        public DateTime LastOrderedDate { get; set; }
    }
}
