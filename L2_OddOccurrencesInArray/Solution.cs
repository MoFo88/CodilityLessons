using System.Linq;

namespace L2_OddOccurrencesInArray
{
    class Solution
    {
        // 100% score
        public int solution(int[] A)
        {
            var grouped = A.GroupBy(a => a);

            var unpaired = grouped.Single(g => g.Count()%2 == 1);

            return unpaired.Key;
        }
    }
}