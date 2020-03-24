using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Math.Services.Extensions;

namespace Math.Services
{
    public class ElimanteOddNumbers
    {
        // "string[] array" > List<string>
        public static string RemoveOddNumbers(List<string> listOfString)
        {
            var result = string.Empty;

            if (listOfString == null || listOfString.Count == 0)
            {
                return result;
            }

            // Zrobic z tego Tool > Extension method
            var withOutOddNumbers = RemoveOddNumbers(listOfString.ToIntList());

            if (!withOutOddNumbers.Any())
            {
                return result;
            }

            var strNumbers = withOutOddNumbers
                    .Select(i => i.ToString(CultureInfo.InvariantCulture))
                    .Aggregate((s1, s2) => s1 + ", " + s2);
            return strNumbers;
        }

        private static List<int> RemoveOddNumbers(List<int> listNumbers)
        {           
            foreach (int currentValue in listNumbers.ToList())
            {                
                if (currentValue % 2 != 0)
                {
                    listNumbers.Remove(currentValue);
                }                
            }            
            return listNumbers;
        }
    }
}
