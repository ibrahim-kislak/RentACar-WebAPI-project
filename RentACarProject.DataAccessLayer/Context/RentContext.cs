using RentACarProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccessLayer.Context
{
    public class RentContext :DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Car>Cars { get; set; }
        public DbSet<Order>Orders { get; set; }
    }
}
