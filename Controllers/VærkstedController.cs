using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Controllers
{
    public class VærkstedController : Controller
    {
        // GET: VærkstedController
        public ActionResult Index()
        {
            return View(new Models.Værksted());
        }

        // GET: VærkstedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VærkstedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VærkstedController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VærkstedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VærkstedController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VærkstedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VærkstedController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
