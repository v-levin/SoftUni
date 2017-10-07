﻿using _2.TODO_List.Models;
using System.Linq;
using System.Web.Mvc;

namespace _2.TODO_List.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new TaskDbContext())
            {
                var tasks = db.Tasks.ToList();

                return View(tasks);
            }
        }
    }
}