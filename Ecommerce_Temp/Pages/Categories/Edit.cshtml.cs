using EcommerceBook_Temp.Data;
using EcommerceBook_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcommerceBook_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {   
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category Edit Successfully";
                return RedirectToPage("Index");
            }
            return Page(); 
        }
    }
}
