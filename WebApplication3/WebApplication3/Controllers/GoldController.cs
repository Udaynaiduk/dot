using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GoldController : Controller
    {
       static List<GoldOrnment> data=new List<GoldOrnment>();
        // GET: GoldController
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
        public ActionResult Create(GoldOrnment go)
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
            IEnumerable<GoldOrnment> foredit=from item in data
                                             where item.Id == id
                                             select item;
            return View(foredit.FirstOrDefault());
        }

        // POST: GoldController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,GoldOrnment edited)

        {
            GoldOrnment foredit=data.FirstOrDefault(x => x.Id == id);
            foredit.Name=edited.Name;
            foredit.Description=edited.Description;
            foredit.Rate=edited.Rate;


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
