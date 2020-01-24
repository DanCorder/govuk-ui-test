using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DccTestWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DccTestWebApp.Controllers
{
    public class MVCController : Controller
    {
        // GET: GovUk
        public ActionResult Index()
        {
            return View();
        }

        // GET: GovUk/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GovUk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GovUk/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVCAddress address)
        {
            return View();
        }

        // GET: GovUk/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GovUk/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GovUk/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GovUk/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}