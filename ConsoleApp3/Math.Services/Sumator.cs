using System.Linq;

namespace Math.Services
{
    public class Sumator
    {
        public static int FromCsv(string csv)
        {
            var sumResult = 0;

            if (string.IsNullOrEmpty(csv))
            {
                return sumResult;
            }

            var numberCandidates = csv.Split(',').ToList();

            foreach (var numberCandidate in numberCandidates)
            {
                int number;

                if (int.TryParse(numberCandidate, out number))
                {
                    sumResult += number;
                }
            }

            return sumResult;
        }
    }
}
