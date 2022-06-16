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
    public class YeteneklerimManager : IYetenekleService
    {
        IYeteneklerDal yeteneklerDal;

        public YeteneklerimManager(IYeteneklerDal yeteneklerDal)
        {
            this.yeteneklerDal = yeteneklerDal;
        }

        public Yetenekler GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Yetenekler t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Yetenekler t)
        {
            throw new NotImplementedException();
        }

        public List<Yetenekler> TGetList()
        {
            return yeteneklerDal.GetList();
            
        }

        public void TUpdate(Yetenekler t)
        {
            throw new NotImplementedException();
        }
    }
}
