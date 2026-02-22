using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.DataAccessLayer.Abstract;
using RentACarProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderdal)
        {
            _orderDal = orderdal;
        }
        public void TDelete(Order entity)
        {
           _orderDal.Delete(entity);
        }

        public Order TGetById(int id)
        {
           return _orderDal.GetById(id);
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
           _orderDal.Update(entity);
        }
    }
}
