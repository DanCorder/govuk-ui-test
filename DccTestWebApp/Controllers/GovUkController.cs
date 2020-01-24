using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GovUkDesignSystem.Parsers;
using DccTestWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DccTestWebApp.Controllers
{
    public class GovUkController : Controller
    {
        //// GET: GovUk
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: GovUk/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: GovUk/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: GovUk/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(GovUkAddress address)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GovUk/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: GovUk/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GovUk/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: GovUk/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
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
            return View(new GovUkPageModel());
        }

        // POST: GovUk/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GovUkPageModel viewModel)
        {
            viewModel.ParseAndValidateParameters(Request, m => m.Address.ID);
            viewModel.ParseAndValidateParameters(Request, m => m.Address.Street);
            viewModel.ParseAndValidateParameters(Request, m => m.Address.PostCode);

            if (viewModel.HasAnyErrors())
            {
                return View(nameof(Create), viewModel);
            }

            try
            {
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
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