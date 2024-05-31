using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL_DataAccessLayer_.Entities;
using MyPortfolio.DAL_DataAccessLayer_.Context;

namespace MyPortfolio.Controllers
{
	public class SkillController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			var values = context.Skills.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddNewSkill()
		{
			return View();
		}
		public IActionResult AddNewSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSkill(int id)
		{

			var value = context.Skills.Find(id);
			context.Skills.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var value =context.Skills.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}


	}
}
