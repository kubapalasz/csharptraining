using System;
using System.Collections.Generic;
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
            if (array == null || array.Length == 0)
            {
                return string.Empty;
            }

            // Poniższy kod nie przewiduje, że `array` może mieć elementy tablicy, które nie są poprawnymi liczbami typu int.
            // Trzeba tak kod zmienić by metoda konwertująca zareagowała gdy natrafi na niepoprawną liczbę... Np.: ominęła ten element
            //int[] numbersArray = Array.ConvertAll(array, int.Parse);

            var validIntegers = new List<int>();
            foreach (var intigerCandidate in array)
            {
                if (int.TryParse(intigerCandidate, out var validInteger))
                {
                    validIntegers.Add(validInteger);
                }
            }

            return MaxFromArray(validIntegers.ToArray()).ToString();
        }
    }
}
