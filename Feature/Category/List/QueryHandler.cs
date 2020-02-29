using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.List
{
    public class QueryHandler : IRequestHandler<Query, ViewModel>
    {
        public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
        {
            var model = new ViewModel();
            model.Categories = await new Repository().GetCategoriesAsync();
            return model;
        }
    }
}
