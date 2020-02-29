using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.Update
{
    public class QueryHandler : IRequestHandler<Query, ViewModel>
    {
        public async Task<ViewModel> Handle(Query request, CancellationToken cancellationToken)
        {
            var model = new ViewModel();
            var categoryDb = await new Repository().GetCategoryAsync(request.Id);
            model.Category = new ViewModel.CategoryInputModel
            {
                Id = categoryDb.Id,
                Name = categoryDb.Name
            };
            return model;
        }
    }
}
