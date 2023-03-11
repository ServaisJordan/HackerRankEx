namespace UnitTest;

public class ConvertingTime
{
    [Theory]
    [InlineData("12:12:12AM", "00:12:12")]
    [InlineData("12:12:12am", "00:12:12")]
    [InlineData("12:12:12PM", "12:12:12")]
    [InlineData("12:12:12pm", "12:12:12")]
    [InlineData("01:12:12AM", "01:12:12")]
    [InlineData("01:12:12PM", "13:12:12")]
    [InlineData("12:40:22AM", "00:40:22")]
    public void Test1(string value, string result)
    {
        Assert.Equal(result, ConverterAMPM.ConvertAMPM(value));
    }
}