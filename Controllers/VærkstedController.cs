﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientsideH2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Controllers
{
    public class VærkstedController : Controller
    {
        public static List<Models.Værksted> værkstedarbjede = new List<Models.Værksted>();
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
            return View(new Models.Værksted());
        }

        // POST: VærkstedController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            try
            {
                Models.Værksted vv = new Models.Værksted();
                vv.Navn = collection["Navn"];
                vv.Email = collection["Email"];
                vv.tlf = collection["tlf"];
                vv.NrPlader = collection["NrPlader"];
                vv.kilometer = collection["kilometer"];
                vv.Model = collection["Model"];
                vv.Afdeling = collection["Afdeling"];
                vv.workorder = collection["workorder"];
                værkstedarbjede.Add(vv);

                DatabaseWrapper wrapper = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=ClientSideDB;Integrated Security=True");
                wrapper.ExecuteQuery($"INSERT INTO dbo.arbejdskort (Navn,Email,Nummerplads,Model,Afdeling,Arbejde, Mobil, Kilometer) VALUES('{værkstedarbjede[0].Navn}','{værkstedarbjede[0].Email}','{værkstedarbjede[0].NrPlader}','{værkstedarbjede[0].Model}','{værkstedarbjede[0].Afdeling}','{værkstedarbjede[0].workorder}','{værkstedarbjede[0].tlf}','{værkstedarbjede[0].kilometer}');");


                return RedirectToAction(nameof(Create));
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
