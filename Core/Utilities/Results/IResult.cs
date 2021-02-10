using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Beginning for base voids
    public interface IResult
    {
        bool Success { get; } //it holds response of the process is success or fail
        string Message { get; } //it holds the response message of the process
    }
}
