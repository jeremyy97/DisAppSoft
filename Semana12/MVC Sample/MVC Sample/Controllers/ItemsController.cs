using Dapper;
using MVC_Sample.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            var result = GetData();
            return View(result);
        }

        // GET: Items/Details/5
        public ActionResult Details(int id)
        {
            var result = GetData(1);
            return View(result);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<Item> items = new List<Item>();
        private List<Item> GetData()
        {
            
            Item item1 = new Item();
            item1.Id = 1;
            item1.Name = "Perros";
            items.Add(item1);

            Item item2 = new Item();
            item2.Id = 2;
            item2.Name = "Gatos";
            items.Add(item2);
            return items;
        }

        private Item GetData(int id)
        {
            Item item = null;
            foreach (Item i in items)
            {
                if(i.Id == id)
                {
                    item = i;
                }
            }
            return item;
        }
    }
}
