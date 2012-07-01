using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    // Interface with generic result
    public interface IProcessor<TProcessingResult>
    {
        TProcessingResult TryExecute();
    }
}
