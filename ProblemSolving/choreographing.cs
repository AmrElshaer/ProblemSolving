namespace ProblemSolving
{
    public static class choreographing
    {



        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 < v2) return "NO";
            var disV = v1 - v2;
            var disX = x2 - x1;
            if (disX < disV || disV == 0 || disX % disV != 0) return "NO";
            return "YES";

        }

    }
}
