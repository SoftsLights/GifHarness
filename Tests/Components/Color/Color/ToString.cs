namespace Tests.Components.Color.Color;

public class ToString
{
    [Fact]
    public void Easy()
    {
        const byte red = 0;
        const byte green = 0;
        const byte blue = 0;

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        string toString = color.ToString();

        const string expectedToString = "Color: (R: 0, G: 0, B: 0)";

        Assert.Equal(expectedToString, toString);
    }

    [Fact]
    public void Normal()
    {
        const byte red = 25;
        const byte green = 176;
        const byte blue = 243;

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        string toString = color.ToString();

        string expectedToString = $"Color: (R: {red}, G: {green}, B: {blue})";

        Assert.Equal(expectedToString, toString);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte red = (byte)random.Next(0, 256);
        byte green = (byte)random.Next(0, 256);
        byte blue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        string toString = color.ToString();

        string expectedToString = $"Color: (R: {red}, G: {green}, B: {blue})";

        Assert.Equal(expectedToString, toString);
    }
}