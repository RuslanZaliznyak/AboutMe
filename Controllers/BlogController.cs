using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AboutMe.Models;


namespace AboutMe.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<AboutMe.Models.Article> articles; 

            using (ApplicationContext db = new ApplicationContext())
            {
                articles = db.Articles.ToList();
            }

            return View(articles);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Article article)
        {
            string _Title = article.Title;
            string _Content = article.Content;

            using (ApplicationContext db = new ApplicationContext())
            {
                Article NewArticle = new Article
                {
                    Title = _Title,
                    Content = _Content
                };

                db.Articles.Add(NewArticle);
                db.SaveChanges();
            }

            return View("Index");
        }
    }
}

