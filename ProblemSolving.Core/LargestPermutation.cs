namespace ProblemSolving.Core
{
    public class LargestPermutation
    {
        public static List<int> LargestPermutationNumList(int k, List<int> arr)
        {
            var data = KeyValueData(arr);
            int numOfSwap = 0, i = 0, n = arr.Count;

            while (numOfSwap < k && i < arr.Count)
            {
                if (arr[i] < n)
                {
                    var index = data[n];
                    arr = SwapBaseData(arr, i, index);
                    data = SwapKeyValueData(arr, data, i, index);
                    numOfSwap++;
                }

                n -= 1;
                i++;
            }
            return arr;
        }

        private static Dictionary<int, int> SwapKeyValueData(List<int> arr, Dictionary<int, int> data, int i, int index)
        {
            (data[arr[i]], data[arr[index]]) = (data[arr[index]], data[arr[i]]);
            return data;
        }

        private static List<int> SwapBaseData(List<int> arr, int i, int index)
        {
            (arr[i], arr[index]) = (arr[index], arr[i]);
            return arr;
        }

        private static Dictionary<int, int> KeyValueData(List<int> arr)
        {
            var data = new Dictionary<int, int>();
            for (int j = 0; j < arr.Count; j++)
            {
                data[arr[j]] = j;
            }

            return data;
        }
    }
}
