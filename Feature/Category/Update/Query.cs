using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.Update
{
    public class Query : IRequest<ViewModel>
    {
        public int Id { get; set; }
    }
}
