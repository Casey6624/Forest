using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Services;
using Forest.Services.Service;
using Forest.Services.IService;

namespace Forest.Controllers
{
    public class MusicController : Controller
    {
        private Forest.Services.IService.IMusicService _musicService;


        public MusicController()
        {
            _musicService = new Forest.Services.Service.MusicService();
        }

        // GET: Music
        public ActionResult Categories()
        {
            return View(_musicService.GetMusicCategories());
        }

        public ActionResult ArtistRecordingsInGenre(string category, string artist)
        {
            ViewBag.Message1 = "Action is artist recordings";
            ViewBag.Message2 = "Category is" + category;
            ViewBag.Message3 = "Artist is " + artist;
            return View();
        }

        public ActionResult GetMusicRecordings(int genre)
        {
            return View(_musicService.GetMusicRecordings(genre));
        }

        public ActionResult Recording(int id)
        {
            return View(_musicService.GetMusicRecording(id));
        }

        // GET: Music/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
