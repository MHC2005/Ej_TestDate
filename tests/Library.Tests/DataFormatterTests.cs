namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Invertir()
    {
        string input = "05/04/2005";
        string expected = "2005-04-05";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }
    [Test]
    public void StringVacio()
    {
        string input = "";
        string expected = "";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
     [Test]
    public void Incorrecto()
    {
        string input = "05-04-2005";
        string expected = "";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreNotEqual(output, expected);
    }
}