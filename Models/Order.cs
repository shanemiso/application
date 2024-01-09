using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public Guid OrderedBy { get; set; }

        public bool IsApproved { get; set; } = false;

        public Guid ApprovedBy { get; set; }

        public DateTime OrderedDate { get; set; }

        public DateTime ApprovedDate { get; set; }
    }
}
