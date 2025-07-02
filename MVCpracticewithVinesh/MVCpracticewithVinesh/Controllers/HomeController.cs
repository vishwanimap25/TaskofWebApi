using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCpracticewithVinesh.Db_context;
using MVCpracticewithVinesh.Models;

namespace MVCpracticewithVinesh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBcontext context;

        public HomeController(ApplicationDBcontext context)
        {
            this.context = context;
        }

       

        public IActionResult Index()
        {
            var user = context.user.OrderBy(x => x.Id).ToList();
            return View(user);
        }

        public IActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            await context.user.AddAsync(user);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var user = await context.user.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            context.user.Remove(user);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
