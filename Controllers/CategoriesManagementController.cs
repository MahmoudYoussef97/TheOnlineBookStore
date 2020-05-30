using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheOnlineBookStore.Models;
using TheOnlineBookStore.Services;

namespace TheOnlineBookStore.Controllers
{
    public class CategoriesManagementController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesManagementController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ??
                throw new ArgumentNullException(nameof(categoryRepository));
        }
        // GET: CategoriesManagement
        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categories = await _categoryRepository.GetAllCategoriesAsync();
            return View(categories);
        }

        // GET: CategoriesManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesManagement/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if(!ModelState.IsValid)
                return View(category);
            
            _categoryRepository.AddCategory(category);
            await _categoryRepository.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: CategoriesManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesManagement/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesManagement/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}