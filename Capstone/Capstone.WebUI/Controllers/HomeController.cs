using Capstone.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        PartnershipNightRepository pnRepo;

        public HomeController()
        {
            pnRepo = new PartnershipNightRepository();
            //pnRepo = new FakePNRepo(); // (create fake repo if necessary)
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
