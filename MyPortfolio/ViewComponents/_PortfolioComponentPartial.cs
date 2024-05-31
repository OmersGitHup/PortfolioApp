using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= context.Portfolios.ToList();
            return View(values);
        }
    }
}
