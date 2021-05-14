using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal ıcarDal)
        {
            _carDal = ıcarDal;
        }

        

        // business ın bildiği tek şey ICarDal'dır.

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
