namespace Tests.Components.Color.Color.HtmlCode;

public class Check
{
    [Fact]
    public void IsAliceBlue()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 248;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.AliceBlue;

        Assert.True(color.IsAliceBlue);
        Assert.True(controlColor.IsAliceBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f0f8ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotAliceBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsAliceBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotAliceBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsAliceBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsAntiqueWhite()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 235;
        const byte expectedBlue = 215;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.AntiqueWhite;

        Assert.True(color.IsAntiqueWhite);
        Assert.True(controlColor.IsAntiqueWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#faebd7";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotAntiqueWhiteEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsAntiqueWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotAntiqueWhite()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsAntiqueWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsAqua()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Aqua;

        Assert.True(color.IsAqua);
        Assert.True(controlColor.IsAqua);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00ffff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotAquaEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsAqua);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotAqua()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsAqua);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsAquamarine()
    {
        const byte expectedRed = 127;
        const byte expectedGreen = 255;
        const byte expectedBlue = 212;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Aquamarine;

        Assert.True(color.IsAquamarine);
        Assert.True(controlColor.IsAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#7fffd4";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotAquamarineEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotAquamarine()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsAzure()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Azure;

        Assert.True(color.IsAzure);
        Assert.True(controlColor.IsAzure);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f0ffff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotAzureEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsAzure);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotAzure()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsAzure);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBeige()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 245;
        const byte expectedBlue = 220;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Beige;

        Assert.True(color.IsBeige);
        Assert.True(controlColor.IsBeige);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f5f5dc";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBeigeEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBeige);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBeige()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBeige);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBisque()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 196;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Bisque;

        Assert.True(color.IsBisque);
        Assert.True(controlColor.IsBisque);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffe4c4";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBisqueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBisque);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBisque()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBisque);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBlack()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Black;

        Assert.True(color.IsBlack);
        Assert.True(controlColor.IsBlack);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#000000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBlackEasy()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBlack);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBlack()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBlack);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBlanchedAlmond()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 235;
        const byte expectedBlue = 205;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.BlanchedAlmond;

        Assert.True(color.IsBlanchedAlmond);
        Assert.True(controlColor.IsBlanchedAlmond);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffebcd";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBlanchedAlmondEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBlanchedAlmond);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBlanchedAlmond()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBlanchedAlmond);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Blue;

        Assert.True(color.IsBlue);
        Assert.True(controlColor.IsBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#0000ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBlueViolet()
    {
        const byte expectedRed = 138;
        const byte expectedGreen = 43;
        const byte expectedBlue = 226;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.BlueViolet;

        Assert.True(color.IsBlueViolet);
        Assert.True(controlColor.IsBlueViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#8a2be2";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBlueVioletEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBlueViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBlueViolet()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBlueViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBrown()
    {
        const byte expectedRed = 165;
        const byte expectedGreen = 42;
        const byte expectedBlue = 42;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Brown;

        Assert.True(color.IsBrown);
        Assert.True(controlColor.IsBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#a52a2a";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBrownEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBrown()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsBurlyWood()
    {
        const byte expectedRed = 222;
        const byte expectedGreen = 184;
        const byte expectedBlue = 135;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.BurlyWood;

        Assert.True(color.IsBurlyWood);
        Assert.True(controlColor.IsBurlyWood);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#deb887";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotBurlyWoodEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsBurlyWood);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotBurlyWood()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsBurlyWood);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCadetBlue()
    {
        const byte expectedRed = 95;
        const byte expectedGreen = 158;
        const byte expectedBlue = 160;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.CadetBlue;

        Assert.True(color.IsCadetBlue);
        Assert.True(controlColor.IsCadetBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#5f9ea0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCadetBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCadetBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCadetBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCadetBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsChartreuse()
    {
        const byte expectedRed = 127;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Chartreuse;

        Assert.True(color.IsChartreuse);
        Assert.True(controlColor.IsChartreuse);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#7fff00";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotChartreuseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsChartreuse);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotChartreuse()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsChartreuse);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsChocolate()
    {
        const byte expectedRed = 210;
        const byte expectedGreen = 105;
        const byte expectedBlue = 30;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Chocolate;

        Assert.True(color.IsChocolate);
        Assert.True(controlColor.IsChocolate);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#d2691e";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotChocolateEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsChocolate);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotChocolate()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsChocolate);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCoral()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 127;
        const byte expectedBlue = 80;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Coral;

        Assert.True(color.IsCoral);
        Assert.True(controlColor.IsCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff7f50";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCoralEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCoral()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCornflowerBlue()
    {
        const byte expectedRed = 100;
        const byte expectedGreen = 149;
        const byte expectedBlue = 237;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.CornflowerBlue;

        Assert.True(color.IsCornflowerBlue);
        Assert.True(controlColor.IsCornflowerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#6495ed";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCornflowerBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCornflowerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCornflowerBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCornflowerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCornsilk()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 248;
        const byte expectedBlue = 220;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Cornsilk;

        Assert.True(color.IsCornsilk);
        Assert.True(controlColor.IsCornsilk);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fff8dc";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCornsilkEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCornsilk);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCornsilk()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCornsilk);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCrimson()
    {
        const byte expectedRed = 220;
        const byte expectedGreen = 20;
        const byte expectedBlue = 60;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Crimson;

        Assert.True(color.IsCrimson);
        Assert.True(controlColor.IsCrimson);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#dc143c";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCrimsonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCrimson);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCrimson()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCrimson);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsCyan()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Cyan;

        Assert.True(color.IsCyan);
        Assert.True(controlColor.IsCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00ffff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotCyanEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotCyan()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 139;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkBlue;

        Assert.True(color.IsDarkBlue);
        Assert.True(controlColor.IsDarkBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00008b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkCyan()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 139;
        const byte expectedBlue = 139;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkCyan;

        Assert.True(color.IsDarkCyan);
        Assert.True(controlColor.IsDarkCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#008b8b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkCyanEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkCyan()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkGoldenrod()
    {
        const byte expectedRed = 184;
        const byte expectedGreen = 134;
        const byte expectedBlue = 11;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkGoldenrod;

        Assert.True(color.IsDarkGoldenrod);
        Assert.True(controlColor.IsDarkGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#b8860b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkGoldenrodEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkGoldenrod()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkGray()
    {
        const byte expectedRed = 169;
        const byte expectedGreen = 169;
        const byte expectedBlue = 169;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkGray;

        Assert.True(color.IsDarkGray);
        Assert.True(controlColor.IsDarkGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#a9a9a9";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 100;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkGreen;

        Assert.True(color.IsDarkGreen);
        Assert.True(controlColor.IsDarkGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#006400";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkKhaki()
    {
        const byte expectedRed = 189;
        const byte expectedGreen = 183;
        const byte expectedBlue = 107;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkKhaki;

        Assert.True(color.IsDarkKhaki);
        Assert.True(controlColor.IsDarkKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#bdb76b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkKhakiEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkKhaki()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkMagenta()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 0;
        const byte expectedBlue = 139;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkMagenta;

        Assert.True(color.IsDarkMagenta);
        Assert.True(controlColor.IsDarkMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#8b008b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkMagentaEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkMagenta()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkOliveGreen()
    {
        const byte expectedRed = 85;
        const byte expectedGreen = 107;
        const byte expectedBlue = 47;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkOliveGreen;

        Assert.True(color.IsDarkOliveGreen);
        Assert.True(controlColor.IsDarkOliveGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#556b2f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkOliveGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkOliveGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkOliveGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkOliveGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkOrange()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 140;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkOrange;

        Assert.True(color.IsDarkOrange);
        Assert.True(controlColor.IsDarkOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff8c00";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkOrangeEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkOrange()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkOrchid()
    {
        const byte expectedRed = 153;
        const byte expectedGreen = 50;
        const byte expectedBlue = 204;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkOrchid;

        Assert.True(color.IsDarkOrchid);
        Assert.True(controlColor.IsDarkOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#9932cc";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkOrchidEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkOrchid()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkRed()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkRed;

        Assert.True(color.IsDarkRed);
        Assert.True(controlColor.IsDarkRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#8b0000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkSalmon()
    {
        const byte expectedRed = 233;
        const byte expectedGreen = 150;
        const byte expectedBlue = 122;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkSalmon;

        Assert.True(color.IsDarkSalmon);
        Assert.True(controlColor.IsDarkSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#e9967a";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkSalmonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkSalmon()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkSeaGreen()
    {
        const byte expectedRed = 143;
        const byte expectedGreen = 188;
        const byte expectedBlue = 139;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkSeaGreen;

        Assert.True(color.IsDarkSeaGreen);
        Assert.True(controlColor.IsDarkSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#8fbc8b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkSeaGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkSeaGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkSlateBlue()
    {
        const byte expectedRed = 72;
        const byte expectedGreen = 61;
        const byte expectedBlue = 139;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkSlateBlue;

        Assert.True(color.IsDarkSlateBlue);
        Assert.True(controlColor.IsDarkSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#483d8b";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkSlateBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkSlateBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkSlateGray()
    {
        const byte expectedRed = 47;
        const byte expectedGreen = 79;
        const byte expectedBlue = 79;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkSlateGray;

        Assert.True(color.IsDarkSlateGray);
        Assert.True(controlColor.IsDarkSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#2f4f4f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkSlateGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkSlateGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkTurquoise()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 206;
        const byte expectedBlue = 209;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkTurquoise;

        Assert.True(color.IsDarkTurquoise);
        Assert.True(controlColor.IsDarkTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00ced1";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkTurquoiseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkTurquoise()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDarkViolet()
    {
        const byte expectedRed = 148;
        const byte expectedGreen = 0;
        const byte expectedBlue = 211;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DarkViolet;

        Assert.True(color.IsDarkViolet);
        Assert.True(controlColor.IsDarkViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#9400d3";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDarkVioletEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDarkViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDarkViolet()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDarkViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDeepPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 20;
        const byte expectedBlue = 147;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DeepPink;

        Assert.True(color.IsDeepPink);
        Assert.True(controlColor.IsDeepPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff1493";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDeepPinkEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDeepPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDeepPink()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDeepPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDeepSkyBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 191;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DeepSkyBlue;

        Assert.True(color.IsDeepSkyBlue);
        Assert.True(controlColor.IsDeepSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00bfff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDeepSkyBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDeepSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDeepSkyBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDeepSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDimGray()
    {
        const byte expectedRed = 105;
        const byte expectedGreen = 105;
        const byte expectedBlue = 105;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DimGray;

        Assert.True(color.IsDimGray);
        Assert.True(controlColor.IsDimGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#696969";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDimGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDimGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDimGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDimGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsDodgerBlue()
    {
        const byte expectedRed = 30;
        const byte expectedGreen = 144;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.DodgerBlue;

        Assert.True(color.IsDodgerBlue);
        Assert.True(controlColor.IsDodgerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#1e90ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotDodgerBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsDodgerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotDodgerBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsDodgerBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsFirebrick()
    {
        const byte expectedRed = 178;
        const byte expectedGreen = 34;
        const byte expectedBlue = 34;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Firebrick;

        Assert.True(color.IsFirebrick);
        Assert.True(controlColor.IsFirebrick);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#b22222";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotFirebrickEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsFirebrick);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotFirebrick()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsFirebrick);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsFloralWhite()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 240;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.FloralWhite;

        Assert.True(color.IsFloralWhite);
        Assert.True(controlColor.IsFloralWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fffaf0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotFloralWhiteEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsFloralWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotFloralWhite()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsFloralWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsForestGreen()
    {
        const byte expectedRed = 34;
        const byte expectedGreen = 139;
        const byte expectedBlue = 34;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.ForestGreen;

        Assert.True(color.IsForestGreen);
        Assert.True(controlColor.IsForestGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#228b22";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotForestGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsForestGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotForestGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsForestGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsFuchsia()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Fuchsia;

        Assert.True(color.IsFuchsia);
        Assert.True(controlColor.IsFuchsia);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff00ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotFuchsiaEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsFuchsia);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotFuchsia()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsFuchsia);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGainsboro()
    {
        const byte expectedRed = 220;
        const byte expectedGreen = 220;
        const byte expectedBlue = 220;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Gainsboro;

        Assert.True(color.IsGainsboro);
        Assert.True(controlColor.IsGainsboro);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#dcdcdc";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGainsboroEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGainsboro);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGainsboro()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGainsboro);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGhostWhite()
    {
        const byte expectedRed = 248;
        const byte expectedGreen = 248;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.GhostWhite;

        Assert.True(color.IsGhostWhite);
        Assert.True(controlColor.IsGhostWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f8f8ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGhostWhiteEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGhostWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGhostWhite()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGhostWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGold()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 215;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Gold;

        Assert.True(color.IsGold);
        Assert.True(controlColor.IsGold);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffd700";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGoldEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGold);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGold()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGold);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGoldenrod()
    {
        const byte expectedRed = 218;
        const byte expectedGreen = 165;
        const byte expectedBlue = 32;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Goldenrod;

        Assert.True(color.IsGoldenrod);
        Assert.True(controlColor.IsGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#daa520";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGoldenrodEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGoldenrod()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGray()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Gray;

        Assert.True(color.IsGray);
        Assert.True(controlColor.IsGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#808080";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 128;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Green;

        Assert.True(color.IsGreen);
        Assert.True(controlColor.IsGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#008000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsGreenYellow()
    {
        const byte expectedRed = 173;
        const byte expectedGreen = 255;
        const byte expectedBlue = 47;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.GreenYellow;

        Assert.True(color.IsGreenYellow);
        Assert.True(controlColor.IsGreenYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#adff2f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotGreenYellowEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsGreenYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotGreenYellow()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsGreenYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsHoneydew()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 255;
        const byte expectedBlue = 240;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Honeydew;

        Assert.True(color.IsHoneydew);
        Assert.True(controlColor.IsHoneydew);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f0fff0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotHoneydewEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsHoneydew);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotHoneydew()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsHoneydew);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsHotPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 105;
        const byte expectedBlue = 180;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.HotPink;

        Assert.True(color.IsHotPink);
        Assert.True(controlColor.IsHotPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff69b4";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotHotPinkEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsHotPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotHotPink()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsHotPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsIndianRed()
    {
        const byte expectedRed = 205;
        const byte expectedGreen = 92;
        const byte expectedBlue = 92;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.IndianRed;

        Assert.True(color.IsIndianRed);
        Assert.True(controlColor.IsIndianRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#cd5c5c";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotIndianRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsIndianRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotIndianRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsIndianRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsIndigo()
    {
        const byte expectedRed = 75;
        const byte expectedGreen = 0;
        const byte expectedBlue = 130;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Indigo;

        Assert.True(color.IsIndigo);
        Assert.True(controlColor.IsIndigo);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#4b0082";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotIndigoEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsIndigo);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotIndigo()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsIndigo);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsIvory()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 240;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Ivory;

        Assert.True(color.IsIvory);
        Assert.True(controlColor.IsIvory);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fffff0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotIvoryEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsIvory);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotIvory()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsIvory);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsKhaki()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 230;
        const byte expectedBlue = 140;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Khaki;

        Assert.True(color.IsKhaki);
        Assert.True(controlColor.IsKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f0e68c";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotKhakiEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotKhaki()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsKhaki);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLavender()
    {
        const byte expectedRed = 230;
        const byte expectedGreen = 230;
        const byte expectedBlue = 250;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Lavender;

        Assert.True(color.IsLavender);
        Assert.True(controlColor.IsLavender);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#e6e6fa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLavenderEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLavender);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLavender()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLavender);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLavenderBlush()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 240;
        const byte expectedBlue = 245;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LavenderBlush;

        Assert.True(color.IsLavenderBlush);
        Assert.True(controlColor.IsLavenderBlush);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fff0f5";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLavenderBlushEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLavenderBlush);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLavenderBlush()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLavenderBlush);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLawnGreen()
    {
        const byte expectedRed = 124;
        const byte expectedGreen = 252;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LawnGreen;

        Assert.True(color.IsLawnGreen);
        Assert.True(controlColor.IsLawnGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#7cfc00";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLawnGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLawnGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLawnGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLawnGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLemonChiffon()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 205;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LemonChiffon;

        Assert.True(color.IsLemonChiffon);
        Assert.True(controlColor.IsLemonChiffon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fffacd";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLemonChiffonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLemonChiffon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLemonChiffon()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLemonChiffon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightBlue()
    {
        const byte expectedRed = 173;
        const byte expectedGreen = 216;
        const byte expectedBlue = 230;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightBlue;

        Assert.True(color.IsLightBlue);
        Assert.True(controlColor.IsLightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#add8e6";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightCoral()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightCoral;

        Assert.True(color.IsLightCoral);
        Assert.True(controlColor.IsLightCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f08080";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightCoralEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightCoral()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightCoral);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightCyan()
    {
        const byte expectedRed = 224;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightCyan;

        Assert.True(color.IsLightCyan);
        Assert.True(controlColor.IsLightCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#e0ffff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightCyanEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightCyan()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightCyan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightGoldenrodYellow()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 250;
        const byte expectedBlue = 210;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightGoldenrodYellow;

        Assert.True(color.IsLightGoldenrodYellow);
        Assert.True(controlColor.IsLightGoldenrodYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fafad2";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightGoldenrodYellowEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightGoldenrodYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightGoldenrodYellow()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightGoldenrodYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightGray()
    {
        const byte expectedRed = 211;
        const byte expectedGreen = 211;
        const byte expectedBlue = 211;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightGray;

        Assert.True(color.IsLightGray);
        Assert.True(controlColor.IsLightGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#d3d3d3";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightGreen()
    {
        const byte expectedRed = 144;
        const byte expectedGreen = 238;
        const byte expectedBlue = 144;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightGreen;

        Assert.True(color.IsLightGreen);
        Assert.True(controlColor.IsLightGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#90ee90";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 182;
        const byte expectedBlue = 193;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightPink;

        Assert.True(color.IsLightPink);
        Assert.True(controlColor.IsLightPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffb6c1";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightPinkEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightPink()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightSalmon()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 160;
        const byte expectedBlue = 122;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightSalmon;

        Assert.True(color.IsLightSalmon);
        Assert.True(controlColor.IsLightSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffa07a";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightSalmonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightSalmon()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightSeaGreen()
    {
        const byte expectedRed = 32;
        const byte expectedGreen = 178;
        const byte expectedBlue = 170;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightSeaGreen;

        Assert.True(color.IsLightSeaGreen);
        Assert.True(controlColor.IsLightSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#20b2aa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightSeaGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightSeaGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightSkyBlue()
    {
        const byte expectedRed = 135;
        const byte expectedGreen = 206;
        const byte expectedBlue = 250;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightSkyBlue;

        Assert.True(color.IsLightSkyBlue);
        Assert.True(controlColor.IsLightSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#87cefa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightSkyBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightSkyBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightSlateGray()
    {
        const byte expectedRed = 119;
        const byte expectedGreen = 136;
        const byte expectedBlue = 153;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightSlateGray;

        Assert.True(color.IsLightSlateGray);
        Assert.True(controlColor.IsLightSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#778899";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightSlateGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightSlateGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightSteelBlue()
    {
        const byte expectedRed = 176;
        const byte expectedGreen = 196;
        const byte expectedBlue = 222;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightSteelBlue;

        Assert.True(color.IsLightSteelBlue);
        Assert.True(controlColor.IsLightSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#b0c4de";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightSteelBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightSteelBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLightYellow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 224;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LightYellow;

        Assert.True(color.IsLightYellow);
        Assert.True(controlColor.IsLightYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffffe0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLightYellowEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLightYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLightYellow()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLightYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLime()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Lime;

        Assert.True(color.IsLime);
        Assert.True(controlColor.IsLime);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00ff00";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLimeEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLime);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLime()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLime);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLimeGreen()
    {
        const byte expectedRed = 50;
        const byte expectedGreen = 205;
        const byte expectedBlue = 50;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.LimeGreen;

        Assert.True(color.IsLimeGreen);
        Assert.True(controlColor.IsLimeGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#32cd32";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLimeGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLimeGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLimeGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLimeGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsLinen()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 240;
        const byte expectedBlue = 230;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Linen;

        Assert.True(color.IsLinen);
        Assert.True(controlColor.IsLinen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#faf0e6";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotLinenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsLinen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotLinen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsLinen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMagenta()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Magenta;

        Assert.True(color.IsMagenta);
        Assert.True(controlColor.IsMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff00ff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMagentaEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMagenta()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMagenta);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMaroon()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Maroon;

        Assert.True(color.IsMaroon);
        Assert.True(controlColor.IsMaroon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#800000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMaroonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMaroon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMaroon()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMaroon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumAquamarine()
    {
        const byte expectedRed = 102;
        const byte expectedGreen = 205;
        const byte expectedBlue = 170;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumAquamarine;

        Assert.True(color.IsMediumAquamarine);
        Assert.True(controlColor.IsMediumAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#66cdaa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumAquamarineEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumAquamarine()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumAquamarine);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 205;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumBlue;

        Assert.True(color.IsMediumBlue);
        Assert.True(controlColor.IsMediumBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#0000cd";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumOrchid()
    {
        const byte expectedRed = 186;
        const byte expectedGreen = 85;
        const byte expectedBlue = 211;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumOrchid;

        Assert.True(color.IsMediumOrchid);
        Assert.True(controlColor.IsMediumOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ba55d3";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumOrchidEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumOrchid()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumPurple()
    {
        const byte expectedRed = 147;
        const byte expectedGreen = 112;
        const byte expectedBlue = 219;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumPurple;

        Assert.True(color.IsMediumPurple);
        Assert.True(controlColor.IsMediumPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#9370db";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumPurpleEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumPurple()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumSeaGreen()
    {
        const byte expectedRed = 60;
        const byte expectedGreen = 179;
        const byte expectedBlue = 113;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumSeaGreen;

        Assert.True(color.IsMediumSeaGreen);
        Assert.True(controlColor.IsMediumSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#3cb371";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumSeaGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumSeaGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumSlateBlue()
    {
        const byte expectedRed = 123;
        const byte expectedGreen = 104;
        const byte expectedBlue = 238;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumSlateBlue;

        Assert.True(color.IsMediumSlateBlue);
        Assert.True(controlColor.IsMediumSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#7b68ee";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumSlateBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumSlateBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumSpringGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 250;
        const byte expectedBlue = 154;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumSpringGreen;

        Assert.True(color.IsMediumSpringGreen);
        Assert.True(controlColor.IsMediumSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00fa9a";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumSpringGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumSpringGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumTurquoise()
    {
        const byte expectedRed = 72;
        const byte expectedGreen = 209;
        const byte expectedBlue = 204;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumTurquoise;

        Assert.True(color.IsMediumTurquoise);
        Assert.True(controlColor.IsMediumTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#48d1cc";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumTurquoiseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumTurquoise()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMediumVioletRed()
    {
        const byte expectedRed = 199;
        const byte expectedGreen = 21;
        const byte expectedBlue = 133;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MediumVioletRed;

        Assert.True(color.IsMediumVioletRed);
        Assert.True(controlColor.IsMediumVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#c71585";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMediumVioletRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMediumVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMediumVioletRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMediumVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMidnightBlue()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 25;
        const byte expectedBlue = 112;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MidnightBlue;

        Assert.True(color.IsMidnightBlue);
        Assert.True(controlColor.IsMidnightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#191970";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMidnightBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMidnightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMidnightBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMidnightBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMintCream()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 255;
        const byte expectedBlue = 250;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MintCream;

        Assert.True(color.IsMintCream);
        Assert.True(controlColor.IsMintCream);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f5fffa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMintCreamEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMintCream);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMintCream()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMintCream);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMistyRose()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 225;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.MistyRose;

        Assert.True(color.IsMistyRose);
        Assert.True(controlColor.IsMistyRose);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffe4e1";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMistyRoseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMistyRose);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMistyRose()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMistyRose);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsMoccasin()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 181;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Moccasin;

        Assert.True(color.IsMoccasin);
        Assert.True(controlColor.IsMoccasin);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffe4b5";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotMoccasinEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsMoccasin);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotMoccasin()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsMoccasin);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNavajoWhite()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 222;
        const byte expectedBlue = 173;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.NavajoWhite;

        Assert.True(color.IsNavajoWhite);
        Assert.True(controlColor.IsNavajoWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffdead";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotNavajoWhiteEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsNavajoWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotNavajoWhite()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsNavajoWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNavy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 128;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Navy;

        Assert.True(color.IsNavy);
        Assert.True(controlColor.IsNavy);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#000080";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotNavyEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsNavy);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotNavy()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsNavy);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOldLace()
    {
        const byte expectedRed = 253;
        const byte expectedGreen = 245;
        const byte expectedBlue = 230;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.OldLace;

        Assert.True(color.IsOldLace);
        Assert.True(controlColor.IsOldLace);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fdf5e6";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOldLaceEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOldLace);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOldLace()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOldLace);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOlive()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 128;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Olive;

        Assert.True(color.IsOlive);
        Assert.True(controlColor.IsOlive);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#808000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOliveEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOlive);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOlive()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOlive);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOliveDrab()
    {
        const byte expectedRed = 107;
        const byte expectedGreen = 142;
        const byte expectedBlue = 35;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.OliveDrab;

        Assert.True(color.IsOliveDrab);
        Assert.True(controlColor.IsOliveDrab);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#6b8e23";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOliveDrabEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOliveDrab);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOliveDrab()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOliveDrab);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOrange()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 165;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Orange;

        Assert.True(color.IsOrange);
        Assert.True(controlColor.IsOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffa500";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOrangeEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOrange()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOrange);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOrangeRed()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 69;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.OrangeRed;

        Assert.True(color.IsOrangeRed);
        Assert.True(controlColor.IsOrangeRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff4500";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOrangeRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOrangeRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOrangeRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOrangeRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsOrchid()
    {
        const byte expectedRed = 218;
        const byte expectedGreen = 112;
        const byte expectedBlue = 214;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Orchid;

        Assert.True(color.IsOrchid);
        Assert.True(controlColor.IsOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#da70d6";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotOrchidEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotOrchid()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsOrchid);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPaleGoldenrod()
    {
        const byte expectedRed = 238;
        const byte expectedGreen = 232;
        const byte expectedBlue = 170;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PaleGoldenrod;

        Assert.True(color.IsPaleGoldenrod);
        Assert.True(controlColor.IsPaleGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#eee8aa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPaleGoldenrodEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPaleGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPaleGoldenrod()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPaleGoldenrod);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPaleGreen()
    {
        const byte expectedRed = 152;
        const byte expectedGreen = 251;
        const byte expectedBlue = 152;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PaleGreen;

        Assert.True(color.IsPaleGreen);
        Assert.True(controlColor.IsPaleGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#98fb98";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPaleGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPaleGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPaleGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPaleGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPaleTurquoise()
    {
        const byte expectedRed = 175;
        const byte expectedGreen = 238;
        const byte expectedBlue = 238;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PaleTurquoise;

        Assert.True(color.IsPaleTurquoise);
        Assert.True(controlColor.IsPaleTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#afeeee";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPaleTurquoiseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPaleTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPaleTurquoise()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPaleTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPaleVioletRed()
    {
        const byte expectedRed = 219;
        const byte expectedGreen = 112;
        const byte expectedBlue = 147;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PaleVioletRed;

        Assert.True(color.IsPaleVioletRed);
        Assert.True(controlColor.IsPaleVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#db7093";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPaleVioletRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPaleVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPaleVioletRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPaleVioletRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPapayaWhip()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 239;
        const byte expectedBlue = 213;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PapayaWhip;

        Assert.True(color.IsPapayaWhip);
        Assert.True(controlColor.IsPapayaWhip);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffefd5";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPapayaWhipEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPapayaWhip);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPapayaWhip()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPapayaWhip);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPeachPuff()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 218;
        const byte expectedBlue = 185;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PeachPuff;

        Assert.True(color.IsPeachPuff);
        Assert.True(controlColor.IsPeachPuff);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffdab9";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPeachPuffEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPeachPuff);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPeachPuff()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPeachPuff);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPeru()
    {
        const byte expectedRed = 205;
        const byte expectedGreen = 133;
        const byte expectedBlue = 63;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Peru;

        Assert.True(color.IsPeru);
        Assert.True(controlColor.IsPeru);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#cd853f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPeruEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPeru);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPeru()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPeru);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 192;
        const byte expectedBlue = 203;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Pink;

        Assert.True(color.IsPink);
        Assert.True(controlColor.IsPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffc0cb";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPinkEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPink()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPink);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPlum()
    {
        const byte expectedRed = 221;
        const byte expectedGreen = 160;
        const byte expectedBlue = 221;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Plum;

        Assert.True(color.IsPlum);
        Assert.True(controlColor.IsPlum);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#dda0dd";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPlumEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPlum);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPlum()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPlum);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPowderBlue()
    {
        const byte expectedRed = 176;
        const byte expectedGreen = 224;
        const byte expectedBlue = 230;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.PowderBlue;

        Assert.True(color.IsPowderBlue);
        Assert.True(controlColor.IsPowderBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#b0e0e6";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPowderBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPowderBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPowderBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPowderBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsPurple()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 0;
        const byte expectedBlue = 128;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Purple;

        Assert.True(color.IsPurple);
        Assert.True(controlColor.IsPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#800080";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotPurpleEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotPurple()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsPurple);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsRed()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Red;

        Assert.True(color.IsRed);
        Assert.True(controlColor.IsRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff0000";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotRedEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotRed()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsRed);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsRosyBrown()
    {
        const byte expectedRed = 188;
        const byte expectedGreen = 143;
        const byte expectedBlue = 143;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.RosyBrown;

        Assert.True(color.IsRosyBrown);
        Assert.True(controlColor.IsRosyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#bc8f8f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotRosyBrownEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsRosyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotRosyBrown()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsRosyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsRoyalBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 105;
        const byte expectedBlue = 225;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.RoyalBlue;

        Assert.True(color.IsRoyalBlue);
        Assert.True(controlColor.IsRoyalBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#4169e1";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotRoyalBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsRoyalBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotRoyalBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsRoyalBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSaddleBrown()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 69;
        const byte expectedBlue = 19;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SaddleBrown;

        Assert.True(color.IsSaddleBrown);
        Assert.True(controlColor.IsSaddleBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#8b4513";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSaddleBrownEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSaddleBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSaddleBrown()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSaddleBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSalmon()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 128;
        const byte expectedBlue = 114;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Salmon;

        Assert.True(color.IsSalmon);
        Assert.True(controlColor.IsSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fa8072";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSalmonEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSalmon()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSalmon);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSandyBrown()
    {
        const byte expectedRed = 244;
        const byte expectedGreen = 164;
        const byte expectedBlue = 96;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SandyBrown;

        Assert.True(color.IsSandyBrown);
        Assert.True(controlColor.IsSandyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f4a460";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSandyBrownEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSandyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSandyBrown()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSandyBrown);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSeaGreen()
    {
        const byte expectedRed = 46;
        const byte expectedGreen = 139;
        const byte expectedBlue = 87;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SeaGreen;

        Assert.True(color.IsSeaGreen);
        Assert.True(controlColor.IsSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#2e8b57";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSeaGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSeaGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSeaGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSeaShell()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 245;
        const byte expectedBlue = 238;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SeaShell;

        Assert.True(color.IsSeaShell);
        Assert.True(controlColor.IsSeaShell);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fff5ee";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSeaShellEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSeaShell);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSeaShell()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSeaShell);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSienna()
    {
        const byte expectedRed = 160;
        const byte expectedGreen = 82;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Sienna;

        Assert.True(color.IsSienna);
        Assert.True(controlColor.IsSienna);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#a0522d";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSiennaEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSienna);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSienna()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSienna);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSilver()
    {
        const byte expectedRed = 192;
        const byte expectedGreen = 192;
        const byte expectedBlue = 192;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Silver;

        Assert.True(color.IsSilver);
        Assert.True(controlColor.IsSilver);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#c0c0c0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSilverEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSilver);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSilver()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSilver);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSkyBlue()
    {
        const byte expectedRed = 135;
        const byte expectedGreen = 206;
        const byte expectedBlue = 235;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SkyBlue;

        Assert.True(color.IsSkyBlue);
        Assert.True(controlColor.IsSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#87ceeb";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSkyBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSkyBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSkyBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSlateBlue()
    {
        const byte expectedRed = 106;
        const byte expectedGreen = 90;
        const byte expectedBlue = 205;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SlateBlue;

        Assert.True(color.IsSlateBlue);
        Assert.True(controlColor.IsSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#6a5acd";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSlateBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSlateBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSlateBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSlateGray()
    {
        const byte expectedRed = 112;
        const byte expectedGreen = 128;
        const byte expectedBlue = 144;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SlateGray;

        Assert.True(color.IsSlateGray);
        Assert.True(controlColor.IsSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#708090";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSlateGrayEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSlateGray()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSlateGray);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSnow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 250;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Snow;

        Assert.True(color.IsSnow);
        Assert.True(controlColor.IsSnow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#fffafa";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSnowEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSnow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSnow()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSnow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSpringGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 127;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SpringGreen;

        Assert.True(color.IsSpringGreen);
        Assert.True(controlColor.IsSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#00ff7f";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSpringGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSpringGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSpringGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsSteelBlue()
    {
        const byte expectedRed = 70;
        const byte expectedGreen = 130;
        const byte expectedBlue = 180;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.SteelBlue;

        Assert.True(color.IsSteelBlue);
        Assert.True(controlColor.IsSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#4682b4";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotSteelBlueEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotSteelBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsSteelBlue);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsTan()
    {
        const byte expectedRed = 210;
        const byte expectedGreen = 180;
        const byte expectedBlue = 140;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Tan;

        Assert.True(color.IsTan);
        Assert.True(controlColor.IsTan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#d2b48c";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotTanEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsTan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotTan()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsTan);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsTeal()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Teal;

        Assert.True(color.IsTeal);
        Assert.True(controlColor.IsTeal);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#008080";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotTealEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsTeal);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotTeal()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsTeal);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsThistle()
    {
        const byte expectedRed = 216;
        const byte expectedGreen = 191;
        const byte expectedBlue = 216;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Thistle;

        Assert.True(color.IsThistle);
        Assert.True(controlColor.IsThistle);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#d8bfd8";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotThistleEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsThistle);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotThistle()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsThistle);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsTomato()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 99;
        const byte expectedBlue = 71;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Tomato;

        Assert.True(color.IsTomato);
        Assert.True(controlColor.IsTomato);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ff6347";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotTomatoEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsTomato);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotTomato()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsTomato);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsTurquoise()
    {
        const byte expectedRed = 64;
        const byte expectedGreen = 224;
        const byte expectedBlue = 208;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Turquoise;

        Assert.True(color.IsTurquoise);
        Assert.True(controlColor.IsTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#40e0d0";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotTurquoiseEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotTurquoise()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsTurquoise);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsViolet()
    {
        const byte expectedRed = 238;
        const byte expectedGreen = 130;
        const byte expectedBlue = 238;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Violet;

        Assert.True(color.IsViolet);
        Assert.True(controlColor.IsViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ee82ee";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotVioletEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotViolet()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsViolet);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsWheat()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 222;
        const byte expectedBlue = 179;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Wheat;

        Assert.True(color.IsWheat);
        Assert.True(controlColor.IsWheat);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f5deb3";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotWheatEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsWheat);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotWheat()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsWheat);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsWhite()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.White;

        Assert.True(color.IsWhite);
        Assert.True(controlColor.IsWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffffff";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotWhiteEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotWhite()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsWhite);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsWhiteSmoke()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 245;
        const byte expectedBlue = 245;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.WhiteSmoke;

        Assert.True(color.IsWhiteSmoke);
        Assert.True(controlColor.IsWhiteSmoke);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#f5f5f5";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotWhiteSmokeEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsWhiteSmoke);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotWhiteSmoke()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsWhiteSmoke);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsYellow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.Yellow;

        Assert.True(color.IsYellow);
        Assert.True(controlColor.IsYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#ffff00";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotYellowEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotYellow()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen,
                expectedBlue);

        Assert.False(color.IsYellow);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsYellowGreen()
    {
        const byte expectedRed = 154;
        const byte expectedGreen = 205;
        const byte expectedBlue = 50;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color controlColor =
            GifHarness.Components.Colors.Color.YellowGreen;

        Assert.True(color.IsYellowGreen);
        Assert.True(controlColor.IsYellowGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);

        Assert.Equal(expectedRed, controlColor.RedComponent);
        Assert.Equal(expectedGreen, controlColor.GreenComponent);
        Assert.Equal(expectedBlue, controlColor.BlueComponent);

        const string expectedHex = "#9acd32";

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));
        Assert.Equal(expectedHex,
            controlColor.ToRgbColorString(includeHash: true,
                useUppercase: false));
    }

    [Fact]
    public void IsNotYellowGreenEasy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.IsYellowGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IsNotYellowGreen()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 179;
        const byte expectedBlue = 45;

        GifHarness.Components.Colors.Color color =
            new(expectedRed, expectedGreen, expectedBlue);

        Assert.False(color.IsYellowGreen);

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }
}