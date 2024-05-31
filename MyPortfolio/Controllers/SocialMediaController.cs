using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;
using MyPortfolio.DAL_DataAccessLayer_.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            var values =context.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNewSocialMedia()
        {
            return View();
        }
        public IActionResult AddNewSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id) { 
            var value=context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
