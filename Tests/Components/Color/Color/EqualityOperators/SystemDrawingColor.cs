namespace Tests.Components.Color.Color.EqualityOperators;

public class SystemDrawingColor
{
    [Fact]
    public void SystemDrawingColorEasyEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(drawingColor == color);
        Assert.True(color == drawingColor);

        Assert.False(drawingColor != color);
        Assert.False(color != drawingColor);
    }

    [Fact]
    public void SystemDrawingColorNormalEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(drawingColor == color);
        Assert.True(color == drawingColor);

        Assert.False(drawingColor != color);
        Assert.False(color != drawingColor);
    }

    [Fact]
    public void SystemDrawingColorRandomEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(color == drawingColor);
        Assert.True(drawingColor == color);

        Assert.False(color != drawingColor);
        Assert.False(drawingColor != color);
    }

    [Fact]
    public void SystemDrawingColorEasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed + 1,
            expectedGreen, expectedBlue);

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);

        Assert.True(color != otherDrawingColor);
        Assert.True(otherDrawingColor != color);
    }

    [Fact]
    public void SystemDrawingColorNormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen + 1, expectedBlue);

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);

        Assert.True(color != otherDrawingColor);
        Assert.True(otherDrawingColor != color);
    }

    [Fact]
    public void SystemDrawingColorRandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);

        Assert.True(color != otherDrawingColor);
        Assert.True(otherDrawingColor != color);
    }

    [Fact]
    public void SystemDrawingColorEasyNotEqualAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;
        const byte expectedAlpha = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha + 1,
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);
    }

    [Fact]
    public void SystemDrawingColorNormalNotEqualAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;
        const byte expectedAlpha = 255;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha - 1,
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);

        Assert.True(color != otherDrawingColor);
        Assert.True(otherDrawingColor != color);
    }

    [Fact]
    public void SystemDrawingColorRandomNotEqualAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);
        byte expectedAlpha = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha,
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.False(color == otherDrawingColor);
        Assert.False(otherDrawingColor == color);

        Assert.True(color != otherDrawingColor);
        Assert.True(otherDrawingColor != color);
    }
}