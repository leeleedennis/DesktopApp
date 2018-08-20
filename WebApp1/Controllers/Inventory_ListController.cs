using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class Inventory_ListController : Controller
    {
        private InventoryEntities1 db = new InventoryEntities1();

        // GET: Inventory_List
        public ActionResult Index()
        {
            return View(db.Inventory_Lists.ToList());
        }

        // GET: Inventory_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory_List inventory_List = db.Inventory_Lists.Find(id);
            if (inventory_List == null)
            {
                return HttpNotFound();
            }
            return View(inventory_List);
        }

        // GET: Inventory_List/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventory_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Item_id,Item_Code,Invent_Type,Item_Description,Pref_Vendor,Reorder_Point_Min,Reorder_Point_Max,Quantity_on_Hand,Quantity_on_Order,Quantity_on_Available,Mark_up_Level,Cost")] Inventory_List inventory_List)
        {
            if (ModelState.IsValid)
            {
                db.Inventory_Lists.Add(inventory_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventory_List);
        }

        // GET: Inventory_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory_List inventory_List = db.Inventory_Lists.Find(id);
            if (inventory_List == null)
            {
                return HttpNotFound();
            }
            return View(inventory_List);
        }

        // POST: Inventory_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Item_id,Item_Code,Invent_Type,Item_Description,Pref_Vendor,Reorder_Point_Min,Reorder_Point_Max,Quantity_on_Hand,Quantity_on_Order,Quantity_on_Available,Mark_up_Level,Cost")] Inventory_List inventory_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventory_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inventory_List);
        }

        // GET: Inventory_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventory_List inventory_List = db.Inventory_Lists.Find(id);
            if (inventory_List == null)
            {
                return HttpNotFound();
            }
            return View(inventory_List);
        }

        // POST: Inventory_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventory_List inventory_List = db.Inventory_Lists.Find(id);
            db.Inventory_Lists.Remove(inventory_List);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}
