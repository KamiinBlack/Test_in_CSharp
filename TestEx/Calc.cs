using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEx
{
    public class Calc
    {
        public float Divide(int dividend, int divisor)
        {
            float result = (float)dividend / divisor;
            return result;
        }
        
        public float DivideAndAddNumber(int dividend, int divisor, int addNumber)
        {
            float result = (float)dividend / divisor;
            result += (float)addNumber;
            return result;
        }
        
        public int BiggerNumber(int firstNum, int secondNum)
        {
            int biggerRes = Math.Max(firstNum, secondNum);
            return biggerRes;
        }

        public float AlwaysZero(int numberToSub)
        {
            int numbToZero = 0;
            numbToZero %= numberToSub;
            return numbToZero;
        }

        public int FloatToIntConvert(float numberToConvert)
        {
            int a = (int)Math.Round(numberToConvert);
            return a;
        }
        
        
        //Dodatkowe
        /*public float DividewitException(int dividend, int divisor)
        {
            //if (divisor == 0) throw new DivideByZeroException();
            float result = (float)dividend / divisor;
            // OnCalculated();
            return result;
        }
        public event EventHandler CalculatedEvent;
 
            protected virtual void OnCalculated()
         {
               var handler = CalculatedEvent;
        if (handler != null) handler(this, EventArgs.Empty);
         }
         
         */
    }
}
