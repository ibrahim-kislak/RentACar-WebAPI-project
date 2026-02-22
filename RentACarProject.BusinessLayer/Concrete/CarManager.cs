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
    public class CarManager : ICarService
    {
        private readonly ICarDal _cardal;
        public void TDelete(Car entity)
        {
            _cardal.Delete(entity);
        }

        public Car TGetById(int id)
        {
            return _cardal.GetById(id);
        }

        public void TInsert(Car entity)
        {
           _cardal.Insert(entity);
        }

        public void TUpdate(Car entity)
        {
            _cardal.Update(entity);
        }
    }
}
