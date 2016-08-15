using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandlerExample
{//delegate signature
    public delegate int sumDelegate(int a, int b);
    class CustomDelegate
    {
        //custom event of sumDelegate type.
        public event sumDelegate   eventSum;


    }
}
