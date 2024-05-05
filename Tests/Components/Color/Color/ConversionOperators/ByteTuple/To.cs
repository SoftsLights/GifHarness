namespace Tests.Components.Color.Color.ConversionOperators.ByteTuple;

public class To
{
    [Fact]
    public void EasyDeconstruct()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) = color;

        Assert.Equal(expectedRed, red);
        Assert.Equal(expectedGreen, green);
        Assert.Equal(expectedBlue, blue);
    }

    [Fact]
    public void NormalDeconstruct()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) = color;

        Assert.Equal(expectedRed, red);
        Assert.Equal(expectedGreen, green);
        Assert.Equal(expectedBlue, blue);
    }

    [Fact]
    public void RandomDeconstruct()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) = color;

        Assert.Equal(expectedRed, red);
        Assert.Equal(expectedGreen, green);
        Assert.Equal(expectedBlue, blue);
    }

    [Fact]
    public void EasyTuple()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) tuple = color;

        Assert.Equal(expectedRed, tuple.red);
        Assert.Equal(expectedGreen, tuple.green);
        Assert.Equal(expectedBlue, tuple.blue);
    }

    [Fact]
    public void NormalTuple()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) tuple = color;

        Assert.Equal(expectedRed, tuple.red);
        Assert.Equal(expectedGreen, tuple.green);
        Assert.Equal(expectedBlue, tuple.blue);
    }

    [Fact]
    public void RandomTuple()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        (byte red, byte green, byte blue) tuple = color;

        Assert.Equal(expectedRed, tuple.red);
        Assert.Equal(expectedGreen, tuple.green);
        Assert.Equal(expectedBlue, tuple.blue);
    }
}