using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;
using MyPortfolio.DAL_DataAccessLayer_;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNewPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewPortfolio(Portfolio Portfolio)
        {
            context.Portfolios.Add(Portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {

            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio Portfolio)
        {
            context.Portfolios.Update(Portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
