using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Controllers
{
    public class BackendController : Controller
    {
        // GET: BackendController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BackendController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BackendController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackendController/Create
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

        // GET: BackendController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BackendController/Edit/5
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

        // GET: BackendController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BackendController/Delete/5
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
