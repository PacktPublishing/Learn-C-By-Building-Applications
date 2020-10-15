using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Demo
{
    class RefLocalsAndReturns
    {
        private int[] _numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void Run()
        {
            // Ref Locals
            int arrayElementByValue = _numberArray[5];
            arrayElementByValue = 600;
            Console.WriteLine($"6th Element Of _numberArray has value of {_numberArray[5]}");

            ref int arrayElementByRef = ref _numberArray[5];
            arrayElementByRef = 600;
            Console.WriteLine($"6th Element Of _numberArray has value of {_numberArray[5]}");

            // Ref Returns
            int byValue = getRefOfIndex(4);
            ref int byRef = ref getRefOfIndex(4);

            byValue = 100;
            Console.WriteLine(_numberArray[4]);

            byRef = 100;
            Console.WriteLine(_numberArray[4]);
        }

        ref int getRefOfIndex(int index)
        {
            return ref _numberArray[index];
        }
    }
}
