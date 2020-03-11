using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Handlers
{
    public abstract class NoReturnHandler<TRequest> : IHandler<TRequest, Unit>
    {
        public async Task<Unit> Handle(TRequest request)
        {
            await HandleAndNoReturn(request);
            return Unit.Value;
        }

        public abstract Task HandleAndNoReturn(TRequest request);
    }
}
