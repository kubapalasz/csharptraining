using System.Collections.Generic;

namespace Math.Services.Extensions
{
    public static class ListExtensions
    {
        public static List<int> ToIntList(this List<string> listOfString)
        {
            var validIntegers = new List<int>();
            foreach (var intigerCandidate in listOfString)
            {
                if (int.TryParse(intigerCandidate, out var validInteger))
                {
                    validIntegers.Add(validInteger);
                }
            }

            return validIntegers;
        }
    }
}
