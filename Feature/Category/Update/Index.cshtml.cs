using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DDDFirst.Feature.Category.Update
{
    public class IndexModel : PageModel
    {
        private readonly IMediator _mediator;
        public IndexModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [BindProperty]
        public ViewModel Data { get; set; }
        public async Task OnGetAsync(Query query)
        {
            Data = await _mediator.Send(query);
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _mediator.Send(new Command { Category = Data.Category });
            return new RedirectResult("/Category/List");
        }
    }
}
