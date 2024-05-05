namespace Tests.Components.Color.Color;

public class HashCode
{
    [Fact]
    public void Easy()
    {
        const byte red = 0;
        const byte green = 0;
        const byte blue = 0;

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        int hashCode = color.GetHashCode();

        int expectedHashCode = System.HashCode.Combine(red, green, blue);

        Assert.Equal(expectedHashCode, hashCode);
    }

    [Fact]
    public void Normal()
    {
        const byte red = 25;
        const byte green = 176;
        const byte blue = 243;

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        int hashCode = color.GetHashCode();

        int expectedHashCode = System.HashCode.Combine(red, green, blue);

        Assert.Equal(expectedHashCode, hashCode);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte red = (byte)random.Next(0, 256);
        byte green = (byte)random.Next(0, 256);
        byte blue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(red, green, blue);

        int hashCode = color.GetHashCode();

        int expectedHashCode = System.HashCode.Combine(red, green, blue);

        Assert.Equal(expectedHashCode, hashCode);
    }

    [Fact]
    public void EasyEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.Equal(color.GetHashCode(), otherColor.GetHashCode());
    }

    [Fact]
    public void NormalEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.Equal(color.GetHashCode(), otherColor.GetHashCode());
    }

    [Fact]
    public void RandomEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.Equal(color.GetHashCode(), otherColor.GetHashCode());
    }

    [Fact]
    public void EasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed + 1,
            expectedGreen, expectedBlue);

        Assert.NotEqual(color.GetHashCode(), otherColor.GetHashCode());
    }

    [Fact]
    public void NormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen + 1, expectedBlue);

        Assert.NotEqual(color.GetHashCode(), otherColor.GetHashCode());
    }

    [Fact]
    public void RandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.NotEqual(color.GetHashCode(), otherColor.GetHashCode());
    }
}