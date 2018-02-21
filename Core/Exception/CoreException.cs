using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blank.Core.Exception
{
    public class CoreException : System.Exception
    {
        public CoreException()
        {
        }

        public CoreException(string message): base(message)
        {
        }

        public CoreException(string message, System.Exception inner)
        {
        }
    }
}
