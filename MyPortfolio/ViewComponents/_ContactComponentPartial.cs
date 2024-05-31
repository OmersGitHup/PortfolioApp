using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
        

    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke() {
            var values=context.Contacts.ToList();
            return View(values); 
        }
    }
}
