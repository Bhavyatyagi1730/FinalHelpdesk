using Service.Implementation;
using Service.Entities;
using Service.CLass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDesk.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        ILogin _login = null;
        public LoginController()
        {
            _login = new Login();
        }
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Userrole user)
        {
            if (ModelState.IsValid == true)
            {
                Userrole obj = new Userrole();
                obj = _login.GetinfoByUserCredentials(user.Email, user.Password, user.Roletype);
                if (obj == null)
                {
                    ViewBag.ErrorMessage = "Login Failed!";
                    return View();
                }
                else
                {
                    Session["Email"] = user.Email;
                    if (obj.Roletype == "admin")    
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else  
                    {
                        return RedirectToAction("Index", "UserDashboard");
                        Session["username"] = user.Name;
                        //Session["password"]=s.password;
                        //return RedirectToAction("Index", "Dashboard");
                    }
                }
            }
            return View();
        }
    }
}