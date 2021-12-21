using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SKYSWebDemo2.Models;

namespace SKYSWebDemo2
{
    public class ShowSupplierModel : PageModel
    {
        private readonly NorthwindContext _context;


        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }

        public ShowSupplierModel(NorthwindContext context)
        {
            _context = context;
        }
        public void OnGet(int id) // EVENTET "nån surfar till sidan"
        {
            var supplier = _context.Suppliers
                .First(r=>r.SupplierId == id);

            CompanyName = supplier.CompanyName;
            ContactName = supplier.ContactName;
            City = supplier.City;
        }
    }
}
