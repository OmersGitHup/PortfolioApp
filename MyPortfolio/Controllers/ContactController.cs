using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_;
using MyPortfolio.DAL_DataAccessLayer_.Context;
using MyPortfolio.DAL_DataAccessLayer_.Entities;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact Contact)
        {
            context.Contacts.Update(Contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
