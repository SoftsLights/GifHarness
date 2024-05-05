namespace Tests.Components.Color.Color.ConversionOperators.ByteTuple;

public class From
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        (byte red, byte green, byte blue) tuple = (expectedRed, expectedGreen,
            expectedBlue);

        GifHarness.Components.Colors.Color color = tuple;

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Normal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        (byte red, byte green, byte blue) tuple = (expectedRed, expectedGreen,
            expectedBlue);

        GifHarness.Components.Colors.Color color = tuple;

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        (byte red, byte green, byte blue) tuple = (expectedRed, expectedGreen,
            expectedBlue);

        GifHarness.Components.Colors.Color color = tuple;

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }
}