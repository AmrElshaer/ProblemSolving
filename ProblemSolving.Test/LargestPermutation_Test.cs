using ProblemSolving.Core;

namespace ProblemSolving.Test
{
    public class LargestPermutation_Test
    {
        public static IEnumerable<object[]> TestLargePermutation =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 1 ,2 ,3 ,4}
                    ,
                    1,
                    new List<int>{ 4 ,2 ,3 ,1}
                },
                new object[]
                {
                    new List<int>{ 4, 2 ,3 ,5 ,1 }
                    ,
                    1,
                    new List<int>{ 5, 2 ,3 ,4 ,1 }
                },
                new object[]
                {
                    new List<int>{ 2,1 }
                    ,
                    1,
                    new List<int>{ 2,1 }
                }
            };
        [Theory]
        [MemberData(nameof(TestLargePermutation))]
        public void GetLargePermutationArr_ValidInput_Success(List<int> arr, int minSwap, List<int> result)
        {
            var res = LargestPermutation.LargestPermutationNumList(minSwap, arr);
            Assert.Equal(result, res);
        }
        public static IEnumerable<object[]> TestLargePermutationNOtValid =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int>{ 1 ,2 ,3 ,4}
                    ,
                    1,
                    new List<int>{ 1 ,2 ,4 ,3}
                },
                new object[]
                {
                    new List<int>{ 4, 2 ,3 ,5 ,1 }
                    ,
                    1,
                    new List<int>{ 2, 5 ,3 ,4 ,1 }
                }
            };
        [Theory]
        [MemberData(nameof(TestLargePermutationNOtValid))]
        public void GetLargePermutationArr_NotValidInput_Success(List<int> arr, int minSwap, List<int> result)
        {
            var res = LargestPermutation.LargestPermutationNumList(minSwap, arr);
            Assert.NotEqual(result, res);
        }
    }
}
