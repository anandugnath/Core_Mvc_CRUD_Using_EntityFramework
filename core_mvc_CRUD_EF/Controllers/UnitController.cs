using core_mvc_CRUD_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            //Active units selecting using EF
            IEnumerable<Units> categoryList = _context.Units.Where(i=>i.Status== "Active").ToList();

            return View(categoryList);
        }

        // GET: UnitController/Details/5
        public ActionResult Details(int id)
        {
            //Finding the unit row by id
            var a = _context.Units.Find(id);
            return View(a);
        }

        // GET: UnitController/Create
        public ActionResult Create()
        {
            //Create View interface 
            //Filling status to dropdown
            ViewBag.Status_lst = new List<SelectListItem>
            {  new SelectListItem{ Text="Active", Value="Active"},
            new SelectListItem{Text="InActive",Value="InActive"},

            };
            return View();
        }

        // POST: UnitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Units obj_units)
        {
            try
            {

                // create using EF 
                //Always Post
                _context.Add(obj_units);
                _context.SaveChanges();
                if (_context.ContextId != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("Error");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitController/Edit/5
        public ActionResult Edit(int Id)
        {
            //Edit View UI Filling the Status to dropdown 
            ViewBag.Status_lst = new List<SelectListItem>
            {  new SelectListItem{ Text="Active", Value="Active"},
            new SelectListItem{Text="InActive",Value="InActive"},

            };
            Units obj_units = new Units();
          //Finding the existing units by ID
            obj_units =  _context.Units.Find(Id);
             /
            return View(obj_units);
        }

        // POST: UnitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Units ObjUnits)
        {
            try
            {
                //Updating the Units
                _context.Units.Update(ObjUnits);
                _context.SaveChanges();
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
            //It is Soft Delete here only updating the status to InActive
            var a=  _context.Units.Find(id);
            a.Status = "InActive";
            _context.Update(a);
            _context.SaveChanges();
            return  RedirectToAction(nameof(Index));
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
