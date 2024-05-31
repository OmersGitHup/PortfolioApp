using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MyPortfolio.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
      
    }
}
