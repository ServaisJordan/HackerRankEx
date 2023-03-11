namespace HackerRankEx
{
    public class Matrix
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftTopStart = 0;
            int rightTopStart = 0;

            leftTopStart = CalculateDiagonal(arr, 1, 0, 1, 1);
            rightTopStart = CalculateDiagonal(arr, 1, arr[1].Count - 1, 1, -1);

            return Math.Abs(leftTopStart - rightTopStart);
        }

        static int CalculateDiagonal(List<List<int>> arr, int iLine, int iColumn, int offsetL, int offsetC)
        {
            int result = 0;

            while (iLine > 0 && iLine < arr.Count)
            {
                result += arr[iLine][iColumn];
                iLine += offsetL;
                iColumn += offsetC;
            }

            return result;
        }
    }
}