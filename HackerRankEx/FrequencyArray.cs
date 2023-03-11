namespace HackerRankEx
{
    public class FrequencyArray
    {
        public static List<int> CreateFrequancy(List<int> arr) 
        {
            int max = arr.Max() + 1;

            var frequencyArray = new List<int>(max);

            arr.ForEach(x => frequencyArray[x] += 1);

            return frequencyArray;
        }
    }
}