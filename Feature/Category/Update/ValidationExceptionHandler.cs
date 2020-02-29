using DDDFirst.Feature.Category.List;
using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDDFirst.Feature.Category.Update
{
    public class ValidationExceptionHandler : IRequestExceptionHandler<Command, Unit, ValidationException>
    {
        public async Task Handle(Command request, ValidationException exception, RequestExceptionHandlerState<Unit> state, CancellationToken cancellationToken)
        {
            foreach (var error in exception.Errors)
            {
                //Log.Error(exception, $"Exception thrown at Command Feature/Category/Update, because {error.ErrorMessage}");
            }
            state.SetHandled(Unit.Value);
        }
    }
}
