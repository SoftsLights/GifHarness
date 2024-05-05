namespace Tests.Components.Color.Color.ConversionOperators.ByteArray;

public class From
{
    [Fact]
    public void Easy()
    {
        byte[] expectedBytes = [0, 0, 0];

        GifHarness.Components.Colors.Color color =
            (GifHarness.Components.Colors.Color)expectedBytes;

        Assert.Equal(expectedBytes[0], color.RedComponent);
        Assert.Equal(expectedBytes[1], color.GreenComponent);
        Assert.Equal(expectedBytes[2], color.BlueComponent);
    }

    [Fact]
    public void Normal()
    {
        byte[] expectedBytes = [25, 176, 243];

        GifHarness.Components.Colors.Color color =
            (GifHarness.Components.Colors.Color)expectedBytes;

        Assert.Equal(expectedBytes[0], color.RedComponent);
        Assert.Equal(expectedBytes[1], color.GreenComponent);
        Assert.Equal(expectedBytes[2], color.BlueComponent);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte[] expectedBytes =
        [
            (byte)random.Next(0, 256),
            (byte)random.Next(0, 256),
            (byte)random.Next(0, 256)
        ];

        GifHarness.Components.Colors.Color color =
            (GifHarness.Components.Colors.Color)expectedBytes;

        Assert.Equal(expectedBytes[0], color.RedComponent);
        Assert.Equal(expectedBytes[1], color.GreenComponent);
        Assert.Equal(expectedBytes[2], color.BlueComponent);
    }

    [Fact]
    public void InvalidSmall()
    {
        byte[] expectedBytes = [0, 0];

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)expectedBytes);
    }

    [Fact]
    public void InvalidLarge()
    {
        byte[] expectedBytes = [0, 0, 0, 0];

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)expectedBytes);
    }

    [Fact]
    public void InvalidEmpty()
    {
        byte[] expectedBytes = [];

        Assert.Throws<ArgumentException>(() =>
            (GifHarness.Components.Colors.Color)expectedBytes);
    }
}