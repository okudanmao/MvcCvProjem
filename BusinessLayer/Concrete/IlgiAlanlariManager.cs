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
    public class IlgiAlanlariManager : IilgiAlanlariService
    {
        IilgiAlanlariDal ilgiAlanlariDal;

        public IlgiAlanlariManager(IilgiAlanlariDal ilgiAlanlariDal)
        {
            this.ilgiAlanlariDal = ilgiAlanlariDal;
        }

        public IlgiAlanlari GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(IlgiAlanlari t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(IlgiAlanlari t)
        {
            throw new NotImplementedException();
        }

        public List<IlgiAlanlari> TGetList()
        {
            return ilgiAlanlariDal.GetList();
        }

        public void TUpdate(IlgiAlanlari t)
        {
            throw new NotImplementedException();
        }
    }
}
