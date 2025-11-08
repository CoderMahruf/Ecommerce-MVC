using EcommerceBook_Temp.Data;
using EcommerceBook_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcommerceBook_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category Create Successfully";
            return RedirectToPage("Index");
        }
    }
}    
