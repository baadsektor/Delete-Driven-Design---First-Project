using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDDFirst.Infrastructure
{
    public class MediatorPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            //Log.Debug($"-- Handling request: {request.GetType()} | Awaiting response: {next.GetType()}");
            var response = await next();
            //Log.Debug($"-- Finished request: {request.GetType()}");
            return response;
        }
    }
}
