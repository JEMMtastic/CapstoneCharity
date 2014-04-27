using Capstone.Domain.Concrete;
using Capstone.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.WebUI.Controllers
{
    public class HomeController : Controller
    {
        PartnershipNightInterface pnRepo;
        UserInterface uRepo;
        CharityInterface cRepo;
        BvLocationInterface lRepo;
        StatsInfoInterface sRepo;

        // The default constructor is called by the framework
        public HomeController()
        {
            uRepo = new UserRepository();
            pnRepo = new PartnershipNightRepository();
            cRepo = new CharityRepository();
            lRepo = new BvLocationRepository();
            sRepo = new StatsInfoRepository();

        }

        // Use this for dependency injection
        public HomeController(UserInterface iUser, PartnershipNightInterface iPn, CharityInterface iChar, BvLocationInterface iLoc, StatsInfoInterface iStats)
        {
            uRepo = iUser;
            pnRepo = iPn;
            cRepo = iChar;
            lRepo = iLoc;
            sRepo = iStats;
        }

        public ActionResult Index()
        {
            //data to get db up and running -- delete when done
            //add a user
            return View();
        }

    }
}
