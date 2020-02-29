using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace DDDFirst.Feature.Category.Update
{
    public class CommandHandler : IRequestHandler<Command>
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var result = new CommandValidator().Validate(request);
            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            await new Repository().UpdateCategoryAsync(request.Category);
            return Unit.Value;
        }
    }
}
