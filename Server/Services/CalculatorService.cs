using BlazorApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Server.Services
{
    public class CalculatorService : ICalculatorService
    {
        public ValueTask<MultiplyResult> MultiplyAsync(MultiplyRequest request)
            => new ValueTask<MultiplyResult>(new MultiplyResult { Result = request.X * request.Y });
    }
}
