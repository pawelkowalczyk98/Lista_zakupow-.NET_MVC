using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;


namespace mvc.Controllers
{
    public class ListController : Controller
    {
  

        private static IList<ListModel> lists = new List<ListModel>()
        {
            new ListModel() {ListId = 1, Name = "Mleko", Description = "2 Litry 3,2 %", Done = false },
            new ListModel() {ListId = 2, Name = "Chleb", Description = "¯ytni", Done = true },
            new ListModel() {ListId = 3, Name = "Mas³o", Description = "2 sztuki", Done = false }
        };
        // GET: List
        public ActionResult Index()
        {
            return View(lists);
        }


        // GET: List/Details/5
        public ActionResult Details(int id)
        {
            return View(lists.FirstOrDefault (x => x.ListId == id));
        }

        // GET: List/Create
        public ActionResult Create()
        {
            return View(new ListModel());
        }

        // POST: List/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(ListModel listmodel)
        {
            listmodel.ListId = lists.Count + 1;
            lists.Add(listmodel);
            return RedirectToAction(nameof(Index));
        }
        // GET: List/Edit/5
        public ActionResult Edit(int id)
        {
            return View(lists.FirstOrDefault(x => x.ListId == id));
        }

        // POST: List/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ListModel listModel)
        {
            ListModel list = lists.FirstOrDefault(x => x.ListId == id);
            list.Name = listModel.Name;
            list.Description = listModel.Description;
            list.Done = listModel.Done;

            return RedirectToAction(nameof(Index));
        }

        // POST: List/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ListModel listModel)
        {
            ListModel list = lists.FirstOrDefault(x => x.ListId == id);
            lists.Remove(list);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {

            return View(lists.FirstOrDefault(x => x.ListId == id));

        }

        // GET: List/Done/5
        public ActionResult Done(int id)
        {
            ListModel list = lists.FirstOrDefault(x => x.ListId == id);
            list.Done = true;
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Opis(int id)
        {

            return View();

        }
    }
}