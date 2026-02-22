using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.EntityLayer.Concrete
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public List<Order > Orders { get; set; }
    }
}
