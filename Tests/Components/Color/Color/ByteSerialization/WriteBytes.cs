namespace Tests.Components.Color.Color.ByteSerialization;

public class WriteBytes
{
    [Fact]
    public void EasyStatic()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }

    [Fact]
    public void NormalStatic()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }

    [Fact]
    public void RandomStatic()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }

    [Fact]
    public void EasyInstance()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }

    [Fact]
    public void NormalInstance()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }

    [Fact]
    public void RandomInstance()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.Equal(expectedRed, bytes[0]);
        Assert.Equal(expectedGreen, bytes[1]);
        Assert.Equal(expectedBlue, bytes[2]);
    }
}