using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User Ryan = new User()
            {
                FirstName = "Ryan",
                LastName = "Baermann"
            };

            User Rebecca = new User()
            {
                FirstName = "Rebecca",
                LastName = "Baermann"
            };

            User Alice = new User()
            {
                FirstName = "Alice",
                LastName = "Baermann"
            };

            List<User> AllUsers = new List<User>()
            {
                Ryan, Rebecca, Alice
            };

            return View("Users", AllUsers);
        }

        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            User SomeUser = new User()
            {
                FirstName = "Alice",
                LastName = "Baermann"
            };

            return View("SomeUser", SomeUser);
        }
    }
}
