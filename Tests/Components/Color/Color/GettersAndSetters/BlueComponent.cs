namespace Tests.Components.Color.Color.GettersAndSetters;

public class BlueComponent
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        const byte newBlue = 255;

        color.BlueComponent = newBlue;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(newBlue, color.BlueComponent);
    }

    [Fact]
    public void Normal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        const byte newBlue = 67;

        color.BlueComponent = newBlue;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(newBlue, color.BlueComponent);
    }

    [Fact]
    public void Random()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte newBlue = (byte)random.Next(0, 256);

        color.BlueComponent = newBlue;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(newBlue, color.BlueComponent);
    }
}