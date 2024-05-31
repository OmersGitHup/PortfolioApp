using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext MyPortfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=MyPortfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=MyPortfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = MyPortfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
