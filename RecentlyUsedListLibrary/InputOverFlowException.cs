using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  RecentlyUsedListLibrary
{
    public class InputOverFlowException : Exception
    {
        public InputOverFlowException(String mesage)
            : base(mesage)
        {

        }
    }
}
