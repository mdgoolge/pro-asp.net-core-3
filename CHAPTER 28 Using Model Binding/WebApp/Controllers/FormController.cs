using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace WebApp.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class FormController : Controller
    {
        private DataContext context;
        public FormController(DataContext dbContext)
        {
            context = dbContext;
        }
        public async Task<IActionResult> Index(long? id)
        {
            ViewBag.Categories
   = new SelectList(context.Categories, "CategoryId", "Name");
            return View("Form", await context.Products.Include(p => p.Category)
                        .Include(p => p.Supplier).FirstOrDefaultAsync(p => p.ProductId == id
                            ||p.ProductId==id));
        }
        [HttpPost]
        public IActionResult SubmitForm(Product product)
        {
            TempData["product"] = System.Text.Json.JsonSerializer.Serialize(product);

            return RedirectToAction(nameof(Results));
        }
        public IActionResult Results()
        {
            return View(TempData);
        }
    }
}