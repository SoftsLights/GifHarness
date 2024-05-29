namespace Tests.Components.Color.Color.ConversionOperators.SystemDrawingColor;

public class To
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen, expectedBlue);


        System.Drawing.Color drawingColor = color;

        Assert.Equal(expectedRed, drawingColor.R);
        Assert.Equal(expectedGreen, drawingColor.G);
        Assert.Equal(expectedBlue, drawingColor.B);
        Assert.Equal(byte.MaxValue, drawingColor.A);
    }

    [Fact]
    public void Normal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen, expectedBlue);

        System.Drawing.Color drawingColor = color;

        Assert.Equal(expectedRed, drawingColor.R);
        Assert.Equal(expectedGreen, drawingColor.G);
        Assert.Equal(expectedBlue, drawingColor.B);
        Assert.Equal(byte.MaxValue, drawingColor.A);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen, expectedBlue);


        System.Drawing.Color drawingColor = color;

        Assert.Equal(expectedRed, drawingColor.R);
        Assert.Equal(expectedGreen, drawingColor.G);
        Assert.Equal(expectedBlue, drawingColor.B);
        Assert.Equal(byte.MaxValue, drawingColor.A);
    }
}