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
            IEnumerable<Units> categoryList = _context.Units.Where(i=>i.Status== "Active").ToList();

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

            ViewBag.Status_lst = new List<SelectListItem>
            {  new SelectListItem{ Text="Active", Value="Active"},
            new SelectListItem{Text="InActive",Value="InActive"},

            };
            Units obj_units = new Units();
            obj_units =  _context.Units.Find(Id);
             
            return View(obj_units);
        }

        // POST: UnitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Units ObjUnits)
        {
            try
            {
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
