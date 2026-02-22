using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
