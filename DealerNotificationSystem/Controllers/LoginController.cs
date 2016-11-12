using System.Web.Mvc;

namespace DNS.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginOperation()
        {
            return Redirect("/Home/Index");
        }
    }
}