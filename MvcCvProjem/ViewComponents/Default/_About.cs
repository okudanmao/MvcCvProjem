using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcCvProjem.ViewComponents.Default
{
    public class _About:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
           var values =  aboutManager.TGetList();
            return View(values);
        }
    }
}
