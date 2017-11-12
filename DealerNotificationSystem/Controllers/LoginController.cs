using System.Web.Mvc;
using Dns.DbContext;
using System.Web.Security;

namespace DNS.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {
            // Lets first check if the Model is valid or not
            if (ModelState.IsValid)
            {
                DNSEntities entities = new DNSEntities();
                    string username = model.UserName;
                    string password = model.Password;

                    bool userValid = entities.Users.Any(user => user.username == username && user.password == password);

                    // User found in the database
                    if (userValid)
                    {

                        FormsAuthentication.SetAuthCookie(username, false);
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    }
                
            }

            return View(model);
        }
    }
}