using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent //ctrl+. miras alma
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
