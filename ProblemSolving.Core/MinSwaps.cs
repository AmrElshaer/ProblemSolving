namespace ProblemSolving.Core
{
    public class MinSwaps
    {
        public static int MinimumSwaps(int[] arr)
        {

            var visited = new bool[arr.Length];
            var modeMap = GenerateHashMap(arr);

            int numOfSwap = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                if (!visited[i - 1])
                {
                    visited[i - 1] = true;
                    if (modeMap[i] != i)
                    {
                        int c = modeMap[i];
                        while (!visited[c - 1])
                        {
                            visited[c - 1] = true;
                            c = modeMap[c];
                            numOfSwap++;
                        }
                    }

                }

            }
            return numOfSwap;
        }

        private static Dictionary<int, int> GenerateHashMap(int[] arr)
        {
            var hashMap = new Dictionary<int, int>();
            for (int i = 1; i <= arr.Length; i++)
            {
                hashMap.Add(i, arr[i - 1]);
            }

            return hashMap;
        }
    }
}
