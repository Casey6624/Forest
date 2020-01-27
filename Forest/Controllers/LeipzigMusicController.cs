using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Leipzig.Services.LeipzigServices;
using Leipzig.Services.Service;

namespace Forest.Controllers
{
    public class LeipzigMusicController : Controller
    {
        private Leipzig.Services.LeipzigServices.ForestWebService _remoteService;

        public LeipzigMusicController()
        {
            _remoteService = new ForestWebService();
        }
        // GET: LeipzigMusic
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetLeipzigMusicCategories(int genre)
        {
            return View(_remoteService.GetMusicRecordings(genre));
        }
    }
}