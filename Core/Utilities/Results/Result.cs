using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Overloading
        public Result(bool successed, string message) : this(successed)
        {
            Message = message;
        }

        public Result(bool successed)
        {
            Successed= successed;
        }

        public bool Successed { get; }

        public string Message { get; }
    }
}
