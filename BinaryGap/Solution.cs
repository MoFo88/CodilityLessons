namespace BinaryGap
{
    class Solution
    {
        // 100% score
        public int solution(int N)
        {
            var currentGap = 0;
            var maxGap = 0;
            if (N > 0)
            {
                while (N%2 == 0)
                    N /= 2;

                while (N >= 1)
                {
                    if (N%2 == 1)
                    {
                        currentGap = 0;
                    }
                    else
                    {
                        currentGap++;
                    }

                    maxGap = maxGap <= currentGap ? currentGap : maxGap;
                    N /= 2;
                }
            }

            return maxGap;
        }
    }
}