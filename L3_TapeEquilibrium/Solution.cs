using System.Linq;

class Solution
{
    // 100% score
    public int solution(int[] A)
    {
        //sets cannot be empty
        var maxIndex = A.Length - 1;

        var minDiffFound = int.MaxValue;

        var leftSum = 0;
        var rightSum = A.Sum();

        for (var i = 0; i < maxIndex; i++)
        {
            leftSum += A[i];
            rightSum -= A[i];

            var diff = leftSum - rightSum;
            diff = diff > 0 ? diff : -diff;
            minDiffFound = minDiffFound < diff ? minDiffFound : diff;
        }

        return minDiffFound;
    }
}