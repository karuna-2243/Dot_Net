using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOperations

{
    public  class Operations
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Cannot divide by zero.");
            }
        }

        public int GetArrayElement(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Index is out of range.");
            }
        }
    }
}
