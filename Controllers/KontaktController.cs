using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Controllers
{
    public class KontaktController : Controller
    {
        // GET: KontaktController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KontaktController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KontaktController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KontaktController/Create
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

        // GET: KontaktController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KontaktController/Edit/5
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

        // GET: KontaktController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KontaktController/Delete/5
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
