using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcCvProjem.ViewComponents.Default
{
    public class _Yetenekler:ViewComponent
    {
        YeteneklerimManager yeteneklerimManager = new YeteneklerimManager(new EFYeteneklerDal());
        public IViewComponentResult Invoke()
        {
            var values = yeteneklerimManager.TGetList();    
            return View(values);
        }
    }
}
