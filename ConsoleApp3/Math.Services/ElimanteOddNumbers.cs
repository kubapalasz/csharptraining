using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Math.Services
{
    public class ElimanteOddNumbers
    {
        public static List<int> RemoveOddNumbers(int[] array)
        {           
            
            var listNumbers = array.ToList();
            foreach (int currentValue in listNumbers.ToList())
            {                
                if (currentValue % 2 != 0)
                {
                    listNumbers.Remove(currentValue);
                }                
            }            
            return listNumbers;
        }

        public static string RemoveOddNumbers(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                return string.Empty;
            }
                        
            int[] numbersArray = Array.ConvertAll(array, Converter);

            var validIntegers = new List<int>();
            foreach (var intigerCandidate in array)
            {
                if (int.TryParse(intigerCandidate, out var validInteger))
                {
                    validIntegers.Add(validInteger);
                }
            }
            var withOutOddNumbers = RemoveOddNumbers(validIntegers.ToArray());
            try
            {
                var strNumbers = withOutOddNumbers.Select(i => i.ToString(CultureInfo.InvariantCulture)).Aggregate((s1, s2) => s1 + ", " + s2);
                return strNumbers;
            }
            catch (Exception exception)
            {

            }
            finally
            {

            }
            return string.Empty;            
        }


        // int.Parse() <<<<<<
        private static int Converter(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception exception)
            {
                // log error
            }
            finally
            {
                // close db/http connection 
            }

            return int.MinValue;
        }
    }
}
