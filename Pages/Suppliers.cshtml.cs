using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SKYSWebDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKYSWebDemo2.Pages
{
    public class SupplierModel : PageModel
    {
        // A list of viewmodels (that we have created)
        public List<SupplierViewModel> Suppliers { get; set; }
        private readonly NorthwindContext _dbContext;
        
        private readonly ILogger<SupplierModel> _logger;

        public SupplierModel(ILogger<SupplierModel> logger, NorthwindContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        // A ViewModel that we have created
        public class SupplierViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }

        public void OnGet()
        {
            
            // Lets fill our list with all the suppliers from the database
            Suppliers = _dbContext.Suppliers
                .Select(s => new SupplierViewModel
                {
                    Name = s.CompanyName,
                    City = s.City,
                    Id = s.SupplierId,
                })
                .OrderBy(s => s.Name)
                .ToList();
            
            
            
            
            
            
            
            //Suppliers = new List<SupplierViewModel>()
            //{
            //    new SupplierViewModel{Id=1, Name ="Rich", City="York"},
            //    new SupplierViewModel{Id=1, Name ="Linda", City="Uppsala"},
            //    new SupplierViewModel{Id=1, Name ="Lucas", City="Stockholm"},
            //};
        }
    }
}
