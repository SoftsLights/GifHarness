namespace Tests.Components.Color.Color.GettersAndSetters;

public class GreenComponent
{
    [Fact]
    public void Easy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        const byte newGreen = 255;

        color.GreenComponent = newGreen;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(newGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Normal()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        const byte newGreen = 67;

        color.GreenComponent = newGreen;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(newGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
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

        byte newGreen = (byte)random.Next(0, 256);

        color.GreenComponent = newGreen;
        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(newGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }
}