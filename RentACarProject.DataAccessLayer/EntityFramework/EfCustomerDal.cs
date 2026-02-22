using RentACarProject.DataAccessLayer.Abstract;
using RentACarProject.DataAccessLayer.Repostiries;
using RentACarProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
    }
}
