namespace Tests.Components.Color.Color;

public class ToRgbColorString
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false);

        Assert.Equal("000000", colorString);
    }

    [Fact]
    public void Normal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false);

        Assert.Equal("19b0f3", colorString);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false);

        Assert.Equal($"{expectedRed:x2}{expectedGreen:x2}{expectedBlue:x2}",
            colorString);
    }

    [Fact]
    public void EasyWithPrefix()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, true);

        Assert.Equal("#000000", colorString);
    }

    [Fact]
    public void NormalWithPrefix()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, true);

        Assert.Equal("#19b0f3", colorString);
    }

    [Fact]
    public void RandomWithPrefix()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, true);

        Assert.Equal($"#{expectedRed:x2}{expectedGreen:x2}{expectedBlue:x2}",
            colorString);
    }

    [Fact]
    public void EasyUpperCase()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(true);

        Assert.Equal("000000", colorString);
    }

    [Fact]
    public void NormalUpperCase()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(true);

        Assert.Equal("19B0F3", colorString);
    }

    [Fact]
    public void RandomUpperCase()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(true);

        Assert.Equal($"{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}",
            colorString);
    }

    [Fact]
    public void EasyAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, includeAlpha: true);

        Assert.Equal("000000ff", colorString);
    }

    [Fact]
    public void NormalAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, includeAlpha: true);

        Assert.Equal("19b0f3ff", colorString);
    }

    [Fact]
    public void RandomAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(false, includeAlpha: true);

        Assert.Equal($"{expectedRed:x2}{expectedGreen:x2}{expectedBlue:x2}ff",
            colorString);
    }

    [Fact]
    public void EasyAlphaWithPrefix()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false,
            includeAlpha: true, includeHash: true);

        Assert.Equal("#000000ff", colorString);
    }

    [Fact]
    public void NormalAlphaWithPrefix()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false,
            includeAlpha: true, includeHash: true);

        Assert.Equal("#19b0f3ff", colorString);
    }

    [Fact]
    public void RandomAlphaWithPrefix()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(false,
            includeAlpha: true, includeHash: true);

        Assert.Equal($"#{expectedRed:x2}{expectedGreen:x2}{expectedBlue:x2}ff",
            colorString);
    }

    [Fact]
    public void EasyAlphaUpperCase()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeAlpha: true, useUppercase: true);

        Assert.Equal("000000FF", colorString);
    }

    [Fact]
    public void NormalAlphaUpperCase()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeAlpha: true, useUppercase: true);

        Assert.Equal("19B0F3FF", colorString);
    }

    [Fact]
    public void RandomAlphaUpperCase()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeAlpha: true, useUppercase: true);

        Assert.Equal($"{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}FF",
            colorString);
    }

    [Fact]
    public void EasyUpperCasePrefix()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeHash: true, useUppercase: true);

        Assert.Equal("#000000", colorString);
    }

    [Fact]
    public void NormalUpperCasePrefix()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeHash: true, useUppercase: true);

        Assert.Equal("#19B0F3", colorString);
    }

    [Fact]
    public void RandomUpperCasePrefix()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString =
            color.ToRgbColorString(includeHash: true, useUppercase: true);

        Assert.Equal($"#{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}",
            colorString);
    }

    [Fact]
    public void EasyPrefixUpperCaseAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(includeHash: true,
            includeAlpha: true, useUppercase: true);

        Assert.Equal("#000000FF", colorString);
    }

    [Fact]
    public void NormalPrefixUpperCaseAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(includeHash: true,
            includeAlpha: true, useUppercase: true);

        Assert.Equal("#19B0F3FF", colorString);
    }

    [Fact]
    public void RandomPrefixUpperCaseAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        string colorString = color.ToRgbColorString(includeHash: true,
            includeAlpha: true, useUppercase: true);

        Assert.Equal($"#{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}FF",
            colorString);
    }
}