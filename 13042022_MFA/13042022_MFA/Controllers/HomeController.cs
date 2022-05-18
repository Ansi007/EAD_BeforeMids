using _13042022_MFA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _13042022_MFA.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "My First MVC Application";
        }

        public string AboutUs()
        {
            return "&copyRight 2022";
        }
    }
}