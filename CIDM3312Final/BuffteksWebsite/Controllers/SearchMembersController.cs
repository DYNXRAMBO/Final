using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuffteksWebsite.Models;

namespace BuffteksWebsite.Controllers
{
    public class SearchMembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string MemberResults()
        {
            return "i am here";
        }
    }
}
