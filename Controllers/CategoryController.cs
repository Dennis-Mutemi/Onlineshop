using ecomerce.Data;
using Microsoft.AspNetCore.Mvc;
using ecomerce.Models;
namespace ecomerce.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()        {
            
            List<Category> objcategoryList = _db.Categories.ToList();
            return View(objcategoryList);
        }
        public IActionResult Create() { 
               return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            /*if (obj.name == obj.displayorder.ToString)
            {
                ModelState.AddModelError('name',"Name and display cannot be the same");
            }*/
            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
