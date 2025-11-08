using EcommerceBook_Temp.Data;
using EcommerceBook_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcommerceBook_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IList<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
