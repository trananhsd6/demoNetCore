using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.Utilities.Exceptions
{
    public class demoNetCoreException:Exception
    {
        public demoNetCoreException()
        {
        }

        public demoNetCoreException(string message)
            : base(message)
        {
        }

        public demoNetCoreException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
