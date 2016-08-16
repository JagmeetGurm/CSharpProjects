using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandlerExample
{//delegate signature
    public delegate int NumDelegate(int a, int b);
    class CustomDelegate
    {
        //custom event of sumDelegate type.
        public static event NumDelegate eventNum;

        //delegate method handler
        public static int sumOfNumbers(int a, int b)
        {
            return a + b;
        }
        //anohter delegate method handler
        public static int prodOfNumbers(int a, int b)
        { return a * b; }
        public static int callEvent(int a = 40, int b = 5)
        {
            retSum = ( eventNum(a, b));
            return 0;

        }
        public static int retSum;
    }
}
