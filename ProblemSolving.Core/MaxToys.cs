namespace ProblemSolving.Core
{
    public class MaxToys
    {
        public static int maximumToys(List<int> prices, int k)
        {
            var res = prices.OrderBy(p => p)
                .CountAggregateWhile((init, curr) => init + curr,
                    c => c <= k);
            return res;
        }
    }

    public static class LinqExtension
    {
        public static int CountAggregateWhile<TSource>(this IEnumerable<TSource> source,
            Func<TSource, TSource, TSource> func,
            Func<TSource, bool> predicate)
        {
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                TSource result = e.Current;
                TSource tmp = default(TSource);
                int count = 0;
                while (e.MoveNext() && predicate(tmp = func(result, e.Current)))
                {
                    result = tmp;
                    count++;
                }

                return count;
            }
        }
    }

}
