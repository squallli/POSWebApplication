using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSWeb.Models;
using System.Collections;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace POSWeb.Controllers
{
    public class LoginController : Controller
    {
        private POSContext db = null;
        public LoginController(POSContext context)
        {
            db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckUser(User u)
        {
            try
            {
                ICollection users = db.user.Where(c => c.username == u.username && c.password == u.password).ToList();
                if (users.Count == 0)
                {
                    ModelState.AddModelError("", "請輸入正確的帳號或密碼!");
                    return View("Index");

                }
                else
                {
                    return RedirectToAction("Index", "Main");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("Index");
            }
            
            
        }

    }
}
