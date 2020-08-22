using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentPg234
{
    public class MyOwnException : Exception
    {
        public MyOwnException()
            : base() { }
        public MyOwnException(string message)
            : base(message) { }
    }
}
