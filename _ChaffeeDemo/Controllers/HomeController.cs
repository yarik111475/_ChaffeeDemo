using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using _ChaffeeDemo.Models;
using _ChaffeeDemo.Repositories;

namespace _ChaffeeDemo.Controllers {
    public class HomeController : Controller {
        IUserRepository repository;

        public HomeController(IUserRepository repository) {
            this.repository = repository;
        }
        public IActionResult Index() {
            IEnumerable<UserModel> users = repository.GetUsers();
            return View(users);
        }
    }
}