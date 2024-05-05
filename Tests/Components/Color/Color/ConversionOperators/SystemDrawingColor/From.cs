namespace Tests.Components.Color.Color.ConversionOperators.SystemDrawingColor;

public class From
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = drawingColor;

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

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = drawingColor;

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

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = drawingColor;

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void BadEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const byte badAlpha = 200;

        System.Drawing.Color badDrawingColor = System.Drawing.Color.FromArgb(
            badAlpha, expectedRed,
            expectedGreen, expectedBlue);

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)badDrawingColor);
    }

    [Fact]
    public void BadNormal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        const byte badAlpha = 200;

        System.Drawing.Color badDrawingColor = System.Drawing.Color.FromArgb(
            badAlpha, expectedRed,
            expectedGreen, expectedBlue);

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)badDrawingColor);
    }

    [Fact]
    public void BadRandom()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        const byte badAlpha = 200;

        System.Drawing.Color badDrawingColor = System.Drawing.Color.FromArgb(
            badAlpha, expectedRed,
            expectedGreen, expectedBlue);

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)badDrawingColor);
    }
}