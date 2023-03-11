namespace HackerRankEx
{
    public class OrdreAlpha
    {
        public static string GridChallenge(List<List<char>> grid)
        {
            int i = 0;
            int j = 0;
            bool isAlpha = true;
            char? prec = null;

            while (i < grid.Count() && isAlpha)
            {
                j = 0;
                while (j < grid[i].Count() && isAlpha)
                {
                    if (prec != null) isAlpha = grid[i][j] >= prec;
                    prec = grid[i][j];
                    j++;
                }
                i++;
            }

            return (isAlpha)? "yes" : "no"; 
        }
    }
}