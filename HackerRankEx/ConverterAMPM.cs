namespace HackerRankEx;
public class ConverterAMPM
{
    static public string ConvertAMPM(string s)
    {
        string[] stringList = s.Split(":");
        int hours;
        string resultingHour = "";

        if (stringList[2].Contains("PM", System.StringComparison.CurrentCultureIgnoreCase))
        {
            hours = ReplacePMAM(stringList, "PM");
            if (hours != 12) hours += 12;
        }
        else
        {
            hours = ReplacePMAM(stringList, "AM");
            if (hours == 12) hours = 0;
        }
        if (hours < 10) resultingHour = "0";
        resultingHour = String.Concat(resultingHour, hours.ToString());
        return $"{resultingHour}:{stringList[1]}:{stringList[2]}";
    }

    static int ReplacePMAM(string[] stringList, string indicator)
    {
        stringList[2] = stringList[2].Replace(indicator, null, true, null);
        return int.Parse(stringList[0]);
    }
}