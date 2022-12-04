using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //message' da göndermek istersek altaki constructor çalışacak
        public SuccessResult(string message) : base(true, message)
        {

        }

        //parametre vermeden classı çağırdığımızda ise sadece base classtan dolayı successed değişkenine true set edilmil olacak
        public SuccessResult() : base(true)
        {

        }
    }
}
