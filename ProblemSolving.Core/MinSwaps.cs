namespace ProblemSolving.Core
{
    public class MinSwaps
    {
        public static int MinimumSwaps(int[] arr)
        {

            var visited = new bool[arr.Length];
            var modeMap = new Dictionary<int, int>();
            for (int i = 1; i <= arr.Length; i++)
            {
                modeMap.Add(i, arr[i - 1]);
            }

            int numOfSwap = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                if (!visited[i - 1])
                {
                    visited[i - 1] = true;
                    if (modeMap[i] == i)
                    {
                        continue;
                    }
                    else
                    {
                        int c = modeMap[i];
                        while (!visited[c - 1])
                        {
                            visited[c - 1] = true;
                            var nextNode = modeMap[c];
                            c = nextNode;
                            numOfSwap++;
                        }
                    }
                }

            }
            return numOfSwap;
        }
    }
}
