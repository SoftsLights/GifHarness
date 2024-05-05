namespace Tests.Components.Color.Color.StaticCreationMethods.FromRgbColorString;

public class Valid
{
    [Fact]
    public void EasyWithoutHashWithoutAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string colorString = "000000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void NormalWithoutHashWithoutAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        const string colorString = "19B0F3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        const string lowerCaseColorString = "19b0f3";
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void RandomWithoutHashWithoutAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        string colorString =
            $"{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        string lowerCaseColorString = colorString.ToLower();
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void EasyWithHashWithoutAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string colorString = "#000000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void NormalWithHashWithoutAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        const string colorString = "#19B0F3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        const string lowerCaseColorString = "#19b0f3";
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void RandomWithHashWithoutAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        string colorString =
            $"#{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        string lowerCaseColorString = colorString.ToLower();
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void EasyWithoutHashWithAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string colorString = "000000FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        const string lowerCaseColorString = "000000ff";

        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void NormalWithoutHashWithAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        const string colorString = "19B0F3FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        const string lowerCaseColorString = "19b0f3ff";
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void RandomWithoutHashWithAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        string colorString =
            $"{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        string lowerCaseColorString = colorString.ToLower();
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void EasyWithHashWithAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string colorString = "#000000FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        const string lowerCaseColorString = "#000000ff";

        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void NormalWithHashWithAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        const string colorString = "#19B0F3FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        const string lowerCaseColorString = "#19b0f3ff";
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }

    [Fact]
    public void RandomWithHashWithAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        string colorString =
            $"{expectedRed:X2}{expectedGreen:X2}{expectedBlue:X2}FF";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FromRgbColorString(colorString);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        string lowerCaseColorString = colorString.ToLower();
        GifHarness.Components.Colors.Color lowerCaseColor =
            GifHarness.Components.Colors.Color.FromRgbColorString(
                lowerCaseColorString);

        Assert.Equal(expectedRed, lowerCaseColor.RedComponent);
        Assert.Equal(expectedGreen, lowerCaseColor.GreenComponent);
        Assert.Equal(expectedBlue, lowerCaseColor.BlueComponent);
    }
}