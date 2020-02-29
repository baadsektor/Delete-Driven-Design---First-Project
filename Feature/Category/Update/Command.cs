using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.Update
{
    public class Command : IRequest
    {
        public ViewModel.CategoryInputModel Category { get; set; }
    }
}
