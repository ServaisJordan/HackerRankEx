namespace HackerRankEx
{
    public class LonelyInteger
    {
        static public int SearchLonlyInteger(IEnumerable<int> a)
        {
            Dictionary<int, int> recurence = new Dictionary<int, int>();
            foreach (int integer in a)
            {
                if (recurence.ContainsKey(integer))
                {
                    recurence[integer] += 1;
                }
                else
                {
                    recurence.Add(integer, 1);
                }
            }
            return recurence.First(x => x.Value == 1).Key;
        }
    }
}