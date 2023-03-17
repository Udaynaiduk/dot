using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class GoldController : Controller
    {
        // GET: GoldController
   static     List<Goldornment> data=new List<Goldornment>();
        public ActionResult Index()
        {
            return View(data);
        }

        // GET: GoldController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GoldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoldController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Goldornment go)
        {
            data.Add(go);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GoldController/Edit/5
        public ActionResult Edit(int id)
        {
            IEnumerable<Goldornment> foredit=from item in data
                                                    where item.Id==id
                                                    select item;
                                                
            return View(foredit.FirstOrDefault());
        }

        // POST: GoldController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Goldornment edited)
        {
            Goldornment foredit=data.FirstOrDefault(data=>data.Id==id);
            foredit.Name = edited.Name;
            foredit.Description = edited.Description;
            foredit.Rate = edited.Rate;
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GoldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GoldController/Delete/5
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
