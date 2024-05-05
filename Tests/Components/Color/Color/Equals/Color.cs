namespace Tests.Components.Color.Color.Equals;

public class Color
{
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

        Assert.True(color.Equals(otherColor));
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

        Assert.True(color.Equals(otherColor));
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

        Assert.True(color.Equals(otherColor));
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

        Assert.False(color.Equals(otherColor));
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

        Assert.False(color.Equals(otherColor));
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

        Assert.False(color.Equals(otherColor));
    }
}