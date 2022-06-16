using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcCvProjem.ViewComponents.Default
{
    public class _IlgiAlanlari:ViewComponent
    {
        IlgiAlanlariManager ilgiAlanlariManager = new IlgiAlanlariManager(new EFIlgiAlanlariDal());
        public IViewComponentResult Invoke()
        {
            var values = ilgiAlanlariManager.TGetList();
            return View(values);
        }
    }
}
