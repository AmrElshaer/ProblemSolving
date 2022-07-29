namespace ProblemSolving.Core
{
    public class MagicSquare
    {
        public static int formingMagicSquare(List<List<int>> s)
        {
            var allMaqiceSquare = new int[][][]
            {
                new int[][] {
                new int[]{8, 1, 6 },
                new int[]{3, 5, 7},
                new int[]{4, 9, 2 }
                },
                new int[][]{
                new int[]{6, 1, 8},
                new int[]{7, 5, 3},
                new int[]{2, 9, 4 }
                },
                new int[][]{
                new int[]{4, 9, 2},
                new int[]{3, 5, 7},
                new int[]{8, 1, 6 }
                },
                new int[][]{
                new int[]{2, 9, 4},
                new int[]{7, 5, 3},
                new int[]{6, 1, 8 }
                },
                new int[][]{

                new int[]{8, 3, 4},
                new int[]{1, 5, 9 },
                new int[]{6, 7, 2}
                },
                new int[][]{
                new int[]{4, 3, 8},
                new int[]{9, 5, 1},
                new int[]{2, 7, 6 }
                },
                new int[][]{
                new int[]{6, 7, 2},
                new int[]{1, 5, 9},
                new int[]{8, 3, 4 }
                },
                new int[][]{
                new int[]{2, 7, 6},
                new int[]{9, 5, 1},
                new int[]{4, 3, 8 }
                }
            };
            int minCost = int.MaxValue;
            foreach (var square in allMaqiceSquare)
            {
                int temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        temp += Math.Abs(square[i][j] - s[i][j]);
                    }
                }
                minCost = Math.Min(minCost, temp);
            }
            return minCost;
        }
    }
}
