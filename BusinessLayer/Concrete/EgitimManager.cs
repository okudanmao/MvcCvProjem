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
    public class EgitimManager : IEgitimService
    {
        IEgitimDal egitimDal;

        public EgitimManager(IEgitimDal egitimDal)
        {
            this.egitimDal = egitimDal;
        }

        public Egitim GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Egitim t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Egitim t)
        {
            throw new NotImplementedException();
        }

        public List<Egitim> TGetList()
        {
            return egitimDal.GetList(); 
        }

        public void TUpdate(Egitim t)
        {
            throw new NotImplementedException();
        }
    }
}
