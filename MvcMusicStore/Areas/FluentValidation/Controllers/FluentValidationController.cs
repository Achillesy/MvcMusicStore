using System.Web.Mvc;
using MvcMusicStore.Areas.FluentValidation.Models;

namespace MvcMusicStore.Areas.FluentValidation.Controllers
{
    public class FluentValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View(contact);
        }
    }
}
