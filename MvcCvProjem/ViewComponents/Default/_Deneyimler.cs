using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcCvProjem.ViewComponents.Default
{
    public class _Deneyimler:ViewComponent
    {
        DeneyimlerManager deneyimlerManager = new DeneyimlerManager(new EFDeneyimDal());
        public IViewComponentResult Invoke()
        {
            var values = deneyimlerManager.TGetList();
            return View(values);
        }
    }
}
