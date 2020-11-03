using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientsideH2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsideH2.Controllers
{
    public class MedlemskabController : Controller
    {
        public static List<Models.Medlemskab> medlemmer = new List<Models.Medlemskab>();
        // GET: MedlemskabController
        public ActionResult Index()
        {
            return View(new Models.Medlemskab());
        }

        // GET: MedlemskabController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedlemskabController/Create
        public ActionResult Create()
        {
            return View(new Models.Medlemskab());
        }

        // POST: MedlemskabController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Models.Medlemskab medlem = new Models.Medlemskab();
                medlem.Navn = collection["Navn"];
                medlem.Efternavn = collection["Efternavn"];
                medlem.telefon = collection["telefon"];
                medlem.Adresse = collection["Adresse"];
                medlem.CPR = collection["CPR"];
                medlemmer.Add(medlem);

                DatabaseWrapper wrapper = new DatabaseWrapper("Data Source=01BIBME14RHJ;Initial Catalog=ClientSideDB;Integrated Security=True");
                wrapper.ExecuteQuery($"INSERT INTO dbo.Medlemmer (Navn,Efternavn,telefon,Adresse,CPR) VALUES('{medlemmer[0].Navn}','{medlemmer[0].Efternavn}','{medlemmer[0].telefon}','{medlemmer[0].Adresse}','{medlemmer[0].CPR}')");

                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedlemskabController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedlemskabController/Edit/5
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

        // GET: MedlemskabController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedlemskabController/Delete/5
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
