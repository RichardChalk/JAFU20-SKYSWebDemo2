using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace SKYSWebDemo2.Pages
{
    public class SalaryModel : PageModel
    {
        public string Name { get; set; }
        public string CurrentDay { get; set; }

        public decimal Salary { get; set; }
        public string SalaryType { get; set; }
        public void OnGet()
        {
            // There are no users in the system right now.
            // This shows how we can filter on current user however
            // The base class (PageModel) contains the identity User

            if (base.User.Identity != null && !string.IsNullOrEmpty(base.User.Identity.Name))
            { 
                Name = base.User.Identity.Name;
            }
            else
            {
                Name = "Not logged in";
            }


            CurrentDay = DateTime.Now.DayOfWeek.ToString();
            
            
            SalaryType = "monthly";
            Salary = 12000;
        }
    }
}
