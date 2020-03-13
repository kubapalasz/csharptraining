using System;
using System.Linq;

namespace Math.Services
{
    public class LargestNumber
    {
        public static int? MaxFromArray(int[] array)
        {            
            int? result = null;

            if (array == null || array.Length == 0)
            {
                return result;
            }
            result = array[0];
            foreach (int currentValue in array)
            {                
                if (currentValue > result)
                {
                    result = currentValue;
                }                
            }
            return result;
        }
        public static string MaxFromArray(string[] array)
        {
            string result;
            if (array == null || array.Length == 0)
            {
                return result = "";
            }
            int[] numbersArray = Array.ConvertAll(array, int.Parse);
           return result = MaxFromArray(numbersArray).ToString();            
        }
    }
}
