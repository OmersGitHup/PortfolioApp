using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Context;
using MyPortfolio.DAL_DataAccessLayer_.Entities;



namespace MyPortfolio.Controllers
{
    public class ReferencesController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial Testimonial)
        {
            context.Testimonials.Add(Testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value=context.Testimonials.Find(id);
            return View(value); 
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
