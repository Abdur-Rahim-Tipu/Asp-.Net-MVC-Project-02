using SPL_HOME_TASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPL_HOME_TASK.Controllers
{
    public class DocumentsController : Controller
    {
        private readonly SPL_HOME_TASKEntities db = new SPL_HOME_TASKEntities();
        // GET: Documents
        public DocumentsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
        // GET: Documents
        public ActionResult Index()
        {

            return View(db.DocumentCategoryInfoes.ToList());
        }
        //Partials
        public ActionResult CategoryInsert()
        {
            return PartialView("_CategoryInfoInsert");
        }
        public ActionResult CategoryEdit()
        {
            return PartialView("_CategoryInfoEdit");
        }
        //Data
        [HttpGet]
        public ActionResult CategoryList()
        {
            var data = db.DocumentCategoryInfoes.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult CategoryInsert(DocumentCategoryInfo model)
        {
            var DC =db.DocumentCategoryInfoes.FirstOrDefault();
            if (ModelState.IsValid && DC.CategoryName != model.CategoryName)
            {
                db.DocumentCategoryInfoes.Add(model);
                db.SaveChanges();
                return Json(new { success = true, data = model });

            }
            return Json(new { success = false, data = new { } });
        }
        [HttpPost]
        public ActionResult CategoryEdit(DocumentCategoryInfo model)
        {
            var DC = db.DocumentCategoryInfoes.FirstOrDefault();
            if (ModelState.IsValid && DC.CategoryName != model.CategoryName)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true, data = model });

            }
            return Json(new { success = false, data = new { } });
        }
    }
}