using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DDDFirst.Feature.Category.List
{
    public class IndexModel : PageModel
    {
        public ViewModel Data { get; set; }
        public async Task OnGetAsync()
        {
            Data = new ViewModel();
            Data.Categories = await new Repository().GetCategoriesAsync();
        }
    }
}
