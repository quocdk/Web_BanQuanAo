using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebData.Models;

namespace WebApp.Controllers
{
    public class ChucVuController : Controller
    {
        public ChucVuController()
        {
            
        }
        // GET: ChucVuController
        public async Task<ActionResult> Index()
        {
            string requestURL = "https://localhost:7111/api/ChucVu";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestURL);
            string apiData = await response.Content.ReadAsStringAsync();
            var chucVus = JsonConvert.DeserializeObject<List<ChucVu>>(apiData);
            return View(chucVus);
        }

        // GET: ChucVuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChucVuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChucVuController/Create
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

        // GET: ChucVuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChucVuController/Edit/5
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

        // GET: ChucVuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChucVuController/Delete/5
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
