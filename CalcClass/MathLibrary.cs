using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    public static class MathLibrary
    {
        private static string _lastError = "";
        public static string lastError
        {
            get { return _lastError; }
            set { _lastError = value; }
        }

        public static int Add(long a, long b)
        {
            int result;
            try
            {
                result = (int)(a + b);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            return result;
        }
        public static int Sub(long a, long b)
        {
            int result;
            try
            {
                result = (int)(a - b);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            return result;
        }


        public static int Mult(long a, long b)
        {
            int result;
            try
            {
                result = (int)(a * b);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            return result;
        }

        public static int Div(long a, long b)
        {
            int result;
            try
            {
                result = (int)(a / b);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            catch (DivideByZeroException)
            {
                _lastError = "Error 09";
                result = 0;
            }
              
                return result;
        }
        public static int Mod(long a, long b)
        {
            int result;
            try
            {
                result = (int)(a % b);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            catch (DivideByZeroException)
            {
                _lastError = "Error 09";
                result = 0;
            }
            return result;
        }
      
        public static int ABS(long a)
        {
            int result;
            try
            {
                if (a > 0) return (int)(a);
                else return (int)(-a);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            return result;
        }
        public static int IABS(long a)
        {
            int result;
            try
            {
                if (a > 0) return (int)(-a);
                else return (int)(a);
            }
            catch (OverflowException)
            {
                _lastError = "Error 06";
                result = 0;
            }
            return result;
        }
    }
}
