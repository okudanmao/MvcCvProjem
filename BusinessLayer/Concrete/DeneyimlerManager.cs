using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DeneyimlerManager : IDeneyimService
    {
        IDeneyimDal _deneyimDal;

        public DeneyimlerManager(IDeneyimDal deneyimDal)
        {
            _deneyimDal = deneyimDal;
        }

        public Deneyim GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Deneyim t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Deneyim t)
        {
            throw new NotImplementedException();
        }

        public List<Deneyim> TGetList()
        {
            return _deneyimDal.GetList();   
        }

        public void TUpdate(Deneyim t)
        {
            throw new NotImplementedException();
        }
    }
}
