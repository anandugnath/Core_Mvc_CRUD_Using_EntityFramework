﻿using core_mvc_CRUD_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace core_mvc_CRUD_EF.Controllers
{
    public class UnitController : Controller
    {

        private readonly ApplicationDbContext _context;
        public UnitController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: UnitController
        public ActionResult Index()
        {
            IEnumerable<Units> categoryList = _context.Units.ToList();

            return View(categoryList);
        }

        // GET: UnitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitController/Create
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

        // GET: UnitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitController/Edit/5
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

        // GET: UnitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitController/Delete/5
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