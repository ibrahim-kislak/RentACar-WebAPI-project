using RentACarProject.BusinessLayer.Abstract;
using RentACarProject.DataAccessLayer.Abstract;
using RentACarProject.EntityLayer.Concrete;
using System;

namespace RentACarProject.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
        
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
       
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
           if (entity.CustomerName != null && entity.IdentityCardNumber != null){
                _customerDal.Insert(entity);
            }
            else
            {
                throw new Exception("Hata");
            }
        }

        public void TUpdate(Customer entity)
        {
           _customerDal.Update(entity);
        }
    }
}
