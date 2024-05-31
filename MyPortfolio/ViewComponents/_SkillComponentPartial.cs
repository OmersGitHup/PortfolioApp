using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;
using MyPortfolio.DAL_DataAccessLayer_.Entities;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new  MyPortfolioContext();
        public IViewComponentResult Invoke() 
        { 
            var values =context.Skills.ToList();
            return View(values); 
        
        }
        
    }
}
