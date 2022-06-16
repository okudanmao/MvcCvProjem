using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcCvProjem.ViewComponents.Default
{
    public class _Egitim:ViewComponent
    {
        EgitimManager egitimManager = new EgitimManager(new EFEgitimDal());
        public IViewComponentResult Invoke()
        {
            var values = egitimManager.TGetList();
            return View(values);
        }
    }
}
