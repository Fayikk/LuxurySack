using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        private object added;

        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult(bool success) : base(false)
        {

        }

        public SuccessResult(bool success, object added) : this(success)
        {
            this.added = added;
        }
    }
}
