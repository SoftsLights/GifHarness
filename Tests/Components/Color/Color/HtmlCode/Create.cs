namespace Tests.Components.Color.Color.HtmlCode;

public class Create
{
    [Fact]
    public void AliceBlue()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 248;
        const byte expectedBlue = 255;

        const string expectedHex = "#f0f8ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.AliceBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void AntiqueWhite()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 235;
        const byte expectedBlue = 215;

        const string expectedHex = "#faebd7";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.AntiqueWhite;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Aqua()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        const string expectedHex = "#00ffff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Aqua;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Aquamarine()
    {
        const byte expectedRed = 127;
        const byte expectedGreen = 255;
        const byte expectedBlue = 212;

        const string expectedHex = "#7fffd4";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Aquamarine;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Azure()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        const string expectedHex = "#f0ffff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Azure;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Beige()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 245;
        const byte expectedBlue = 220;

        const string expectedHex = "#f5f5dc";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Beige;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Bisque()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 196;

        const string expectedHex = "#ffe4c4";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Bisque;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Black()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string expectedHex = "#000000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Black;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void BlanchedAlmond()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 235;
        const byte expectedBlue = 205;

        const string expectedHex = "#ffebcd";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.BlanchedAlmond;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Blue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        const string expectedHex = "#0000ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Blue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void BlueViolet()
    {
        const byte expectedRed = 138;
        const byte expectedGreen = 43;
        const byte expectedBlue = 226;

        const string expectedHex = "#8a2be2";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.BlueViolet;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Brown()
    {
        const byte expectedRed = 165;
        const byte expectedGreen = 42;
        const byte expectedBlue = 42;

        const string expectedHex = "#a52a2a";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Brown;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void BurlyWood()
    {
        const byte expectedRed = 222;
        const byte expectedGreen = 184;
        const byte expectedBlue = 135;

        const string expectedHex = "#deb887";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.BurlyWood;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void CadetBlue()
    {
        const byte expectedRed = 95;
        const byte expectedGreen = 158;
        const byte expectedBlue = 160;

        const string expectedHex = "#5f9ea0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.CadetBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Chartreuse()
    {
        const byte expectedRed = 127;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        const string expectedHex = "#7fff00";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Chartreuse;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Chocolate()
    {
        const byte expectedRed = 210;
        const byte expectedGreen = 105;
        const byte expectedBlue = 30;

        const string expectedHex = "#d2691e";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Chocolate;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Coral()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 127;
        const byte expectedBlue = 80;

        const string expectedHex = "#ff7f50";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Coral;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void CornflowerBlue()
    {
        const byte expectedRed = 100;
        const byte expectedGreen = 149;
        const byte expectedBlue = 237;

        const string expectedHex = "#6495ed";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.CornflowerBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Cornsilk()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 248;
        const byte expectedBlue = 220;

        const string expectedHex = "#fff8dc";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Cornsilk;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Crimson()
    {
        const byte expectedRed = 220;
        const byte expectedGreen = 20;
        const byte expectedBlue = 60;

        const string expectedHex = "#dc143c";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Crimson;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Cyan()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        const string expectedHex = "#00ffff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Cyan;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 139;

        const string expectedHex = "#00008b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkCyan()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 139;
        const byte expectedBlue = 139;

        const string expectedHex = "#008b8b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkCyan;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkGoldenrod()
    {
        const byte expectedRed = 184;
        const byte expectedGreen = 134;
        const byte expectedBlue = 11;

        const string expectedHex = "#b8860b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkGoldenrod;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkGray()
    {
        const byte expectedRed = 169;
        const byte expectedGreen = 169;
        const byte expectedBlue = 169;

        const string expectedHex = "#a9a9a9";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 100;
        const byte expectedBlue = 0;

        const string expectedHex = "#006400";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkKhaki()
    {
        const byte expectedRed = 189;
        const byte expectedGreen = 183;
        const byte expectedBlue = 107;

        const string expectedHex = "#bdb76b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkKhaki;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkMagenta()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 0;
        const byte expectedBlue = 139;

        const string expectedHex = "#8b008b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkMagenta;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkOliveGreen()
    {
        const byte expectedRed = 85;
        const byte expectedGreen = 107;
        const byte expectedBlue = 47;

        const string expectedHex = "#556b2f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkOliveGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkOrange()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 140;
        const byte expectedBlue = 0;

        const string expectedHex = "#ff8c00";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkOrange;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkOrchid()
    {
        const byte expectedRed = 153;
        const byte expectedGreen = 50;
        const byte expectedBlue = 204;

        const string expectedHex = "#9932cc";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkOrchid;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkRed()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string expectedHex = "#8b0000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkRed;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkSalmon()
    {
        const byte expectedRed = 233;
        const byte expectedGreen = 150;
        const byte expectedBlue = 122;

        const string expectedHex = "#e9967a";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkSalmon;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkSeaGreen()
    {
        const byte expectedRed = 143;
        const byte expectedGreen = 188;
        const byte expectedBlue = 139;

        const string expectedHex = "#8fbc8b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkSeaGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkSlateBlue()
    {
        const byte expectedRed = 72;
        const byte expectedGreen = 61;
        const byte expectedBlue = 139;

        const string expectedHex = "#483d8b";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkSlateBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkSlateGray()
    {
        const byte expectedRed = 47;
        const byte expectedGreen = 79;
        const byte expectedBlue = 79;

        const string expectedHex = "#2f4f4f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkSlateGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkTurquoise()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 206;
        const byte expectedBlue = 209;

        const string expectedHex = "#00ced1";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkTurquoise;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DarkViolet()
    {
        const byte expectedRed = 148;
        const byte expectedGreen = 0;
        const byte expectedBlue = 211;

        const string expectedHex = "#9400d3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DarkViolet;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DeepPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 20;
        const byte expectedBlue = 147;

        const string expectedHex = "#ff1493";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DeepPink;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DeepSkyBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 191;
        const byte expectedBlue = 255;

        const string expectedHex = "#00bfff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DeepSkyBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DimGray()
    {
        const byte expectedRed = 105;
        const byte expectedGreen = 105;
        const byte expectedBlue = 105;

        const string expectedHex = "#696969";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DimGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void DodgerBlue()
    {
        const byte expectedRed = 30;
        const byte expectedGreen = 144;
        const byte expectedBlue = 255;

        const string expectedHex = "#1e90ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.DodgerBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Firebrick()
    {
        const byte expectedRed = 178;
        const byte expectedGreen = 34;
        const byte expectedBlue = 34;

        const string expectedHex = "#b22222";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Firebrick;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void FloralWhite()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 240;

        const string expectedHex = "#fffaf0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.FloralWhite;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void ForestGreen()
    {
        const byte expectedRed = 34;
        const byte expectedGreen = 139;
        const byte expectedBlue = 34;

        const string expectedHex = "#228b22";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.ForestGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Fuchsia()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        const string expectedHex = "#ff00ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Fuchsia;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Gainsboro()
    {
        const byte expectedRed = 220;
        const byte expectedGreen = 220;
        const byte expectedBlue = 220;

        const string expectedHex = "#dcdcdc";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Gainsboro;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void GhostWhite()
    {
        const byte expectedRed = 248;
        const byte expectedGreen = 248;
        const byte expectedBlue = 255;

        const string expectedHex = "#f8f8ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.GhostWhite;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Gold()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 215;
        const byte expectedBlue = 0;

        const string expectedHex = "#ffd700";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Gold;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Goldenrod()
    {
        const byte expectedRed = 218;
        const byte expectedGreen = 165;
        const byte expectedBlue = 32;

        const string expectedHex = "#daa520";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Goldenrod;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Gray()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        const string expectedHex = "#808080";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Gray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Green()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 128;
        const byte expectedBlue = 0;

        const string expectedHex = "#008000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Green;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void GreenYellow()
    {
        const byte expectedRed = 173;
        const byte expectedGreen = 255;
        const byte expectedBlue = 47;

        const string expectedHex = "#adff2f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.GreenYellow;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Honeydew()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 255;
        const byte expectedBlue = 240;

        const string expectedHex = "#f0fff0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Honeydew;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void HotPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 105;
        const byte expectedBlue = 180;

        const string expectedHex = "#ff69b4";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.HotPink;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void IndianRed()
    {
        const byte expectedRed = 205;
        const byte expectedGreen = 92;
        const byte expectedBlue = 92;

        const string expectedHex = "#cd5c5c";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.IndianRed;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Indigo()
    {
        const byte expectedRed = 75;
        const byte expectedGreen = 0;
        const byte expectedBlue = 130;

        const string expectedHex = "#4b0082";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Indigo;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Ivory()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 240;

        const string expectedHex = "#fffff0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Ivory;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Khaki()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 230;
        const byte expectedBlue = 140;

        const string expectedHex = "#f0e68c";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Khaki;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Lavender()
    {
        const byte expectedRed = 230;
        const byte expectedGreen = 230;
        const byte expectedBlue = 250;

        const string expectedHex = "#e6e6fa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Lavender;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LavenderBlush()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 240;
        const byte expectedBlue = 245;

        const string expectedHex = "#fff0f5";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LavenderBlush;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LawnGreen()
    {
        const byte expectedRed = 124;
        const byte expectedGreen = 252;
        const byte expectedBlue = 0;

        const string expectedHex = "#7cfc00";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LawnGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LemonChiffon()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 205;

        const string expectedHex = "#fffacd";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LemonChiffon;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightBlue()
    {
        const byte expectedRed = 173;
        const byte expectedGreen = 216;
        const byte expectedBlue = 230;

        const string expectedHex = "#add8e6";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightCoral()
    {
        const byte expectedRed = 240;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        const string expectedHex = "#f08080";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightCoral;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightCyan()
    {
        const byte expectedRed = 224;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        const string expectedHex = "#e0ffff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightCyan;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightGoldenrodYellow()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 250;
        const byte expectedBlue = 210;

        const string expectedHex = "#fafad2";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightGoldenrodYellow;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightGray()
    {
        const byte expectedRed = 211;
        const byte expectedGreen = 211;
        const byte expectedBlue = 211;

        const string expectedHex = "#d3d3d3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightGreen()
    {
        const byte expectedRed = 144;
        const byte expectedGreen = 238;
        const byte expectedBlue = 144;

        const string expectedHex = "#90ee90";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightPink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 182;
        const byte expectedBlue = 193;

        const string expectedHex = "#ffb6c1";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightPink;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightSalmon()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 160;
        const byte expectedBlue = 122;

        const string expectedHex = "#ffa07a";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightSalmon;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightSeaGreen()
    {
        const byte expectedRed = 32;
        const byte expectedGreen = 178;
        const byte expectedBlue = 170;

        const string expectedHex = "#20b2aa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightSeaGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightSkyBlue()
    {
        const byte expectedRed = 135;
        const byte expectedGreen = 206;
        const byte expectedBlue = 250;

        const string expectedHex = "#87cefa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightSkyBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightSlateGray()
    {
        const byte expectedRed = 119;
        const byte expectedGreen = 136;
        const byte expectedBlue = 153;

        const string expectedHex = "#778899";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightSlateGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightSteelBlue()
    {
        const byte expectedRed = 176;
        const byte expectedGreen = 196;
        const byte expectedBlue = 222;

        const string expectedHex = "#b0c4de";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightSteelBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LightYellow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 224;

        const string expectedHex = "#ffffe0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LightYellow;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Lime()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        const string expectedHex = "#00ff00";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Lime;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void LimeGreen()
    {
        const byte expectedRed = 50;
        const byte expectedGreen = 205;
        const byte expectedBlue = 50;

        const string expectedHex = "#32cd32";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.LimeGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Linen()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 240;
        const byte expectedBlue = 230;

        const string expectedHex = "#faf0e6";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Linen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Magenta()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 255;

        const string expectedHex = "#ff00ff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Magenta;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Maroon()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string expectedHex = "#800000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Maroon;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumAquamarine()
    {
        const byte expectedRed = 102;
        const byte expectedGreen = 205;
        const byte expectedBlue = 170;

        const string expectedHex = "#66cdaa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumAquamarine;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumBlue()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 205;

        const string expectedHex = "#0000cd";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumOrchid()
    {
        const byte expectedRed = 186;
        const byte expectedGreen = 85;
        const byte expectedBlue = 211;

        const string expectedHex = "#ba55d3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumOrchid;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumPurple()
    {
        const byte expectedRed = 147;
        const byte expectedGreen = 112;
        const byte expectedBlue = 219;

        const string expectedHex = "#9370db";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumPurple;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumSeaGreen()
    {
        const byte expectedRed = 60;
        const byte expectedGreen = 179;
        const byte expectedBlue = 113;

        const string expectedHex = "#3cb371";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumSeaGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumSlateBlue()
    {
        const byte expectedRed = 123;
        const byte expectedGreen = 104;
        const byte expectedBlue = 238;

        const string expectedHex = "#7b68ee";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumSlateBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumSpringGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 250;
        const byte expectedBlue = 154;

        const string expectedHex = "#00fa9a";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumSpringGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumTurquoise()
    {
        const byte expectedRed = 72;
        const byte expectedGreen = 209;
        const byte expectedBlue = 204;

        const string expectedHex = "#48d1cc";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumTurquoise;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MediumVioletRed()
    {
        const byte expectedRed = 199;
        const byte expectedGreen = 21;
        const byte expectedBlue = 133;

        const string expectedHex = "#c71585";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MediumVioletRed;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MidnightBlue()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 25;
        const byte expectedBlue = 112;

        const string expectedHex = "#191970";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MidnightBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MintCream()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 255;
        const byte expectedBlue = 250;

        const string expectedHex = "#f5fffa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MintCream;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void MistyRose()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 225;

        const string expectedHex = "#ffe4e1";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.MistyRose;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Moccasin()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 228;
        const byte expectedBlue = 181;

        const string expectedHex = "#ffe4b5";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Moccasin;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void NavajoWhite()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 222;
        const byte expectedBlue = 173;

        const string expectedHex = "#ffdead";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.NavajoWhite;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Navy()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 128;

        const string expectedHex = "#000080";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Navy;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void OldLace()
    {
        const byte expectedRed = 253;
        const byte expectedGreen = 245;
        const byte expectedBlue = 230;

        const string expectedHex = "#fdf5e6";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.OldLace;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Olive()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 128;
        const byte expectedBlue = 0;

        const string expectedHex = "#808000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Olive;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void OliveDrab()
    {
        const byte expectedRed = 107;
        const byte expectedGreen = 142;
        const byte expectedBlue = 35;

        const string expectedHex = "#6b8e23";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.OliveDrab;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Orange()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 165;
        const byte expectedBlue = 0;

        const string expectedHex = "#ffa500";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Orange;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void OrangeRed()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 69;
        const byte expectedBlue = 0;

        const string expectedHex = "#ff4500";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.OrangeRed;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Orchid()
    {
        const byte expectedRed = 218;
        const byte expectedGreen = 112;
        const byte expectedBlue = 214;

        const string expectedHex = "#da70d6";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Orchid;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PaleGoldenrod()
    {
        const byte expectedRed = 238;
        const byte expectedGreen = 232;
        const byte expectedBlue = 170;

        const string expectedHex = "#eee8aa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PaleGoldenrod;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PaleGreen()
    {
        const byte expectedRed = 152;
        const byte expectedGreen = 251;
        const byte expectedBlue = 152;

        const string expectedHex = "#98fb98";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PaleGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PaleTurquoise()
    {
        const byte expectedRed = 175;
        const byte expectedGreen = 238;
        const byte expectedBlue = 238;

        const string expectedHex = "#afeeee";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PaleTurquoise;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PaleVioletRed()
    {
        const byte expectedRed = 219;
        const byte expectedGreen = 112;
        const byte expectedBlue = 147;

        const string expectedHex = "#db7093";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PaleVioletRed;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PapayaWhip()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 239;
        const byte expectedBlue = 213;

        const string expectedHex = "#ffefd5";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PapayaWhip;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PeachPuff()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 218;
        const byte expectedBlue = 185;

        const string expectedHex = "#ffdab9";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PeachPuff;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Peru()
    {
        const byte expectedRed = 205;
        const byte expectedGreen = 133;
        const byte expectedBlue = 63;

        const string expectedHex = "#cd853f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Peru;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Pink()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 192;
        const byte expectedBlue = 203;

        const string expectedHex = "#ffc0cb";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Pink;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Plum()
    {
        const byte expectedRed = 221;
        const byte expectedGreen = 160;
        const byte expectedBlue = 221;

        const string expectedHex = "#dda0dd";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Plum;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void PowderBlue()
    {
        const byte expectedRed = 176;
        const byte expectedGreen = 224;
        const byte expectedBlue = 230;

        const string expectedHex = "#b0e0e6";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.PowderBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Purple()
    {
        const byte expectedRed = 128;
        const byte expectedGreen = 0;
        const byte expectedBlue = 128;

        const string expectedHex = "#800080";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Purple;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Red()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        const string expectedHex = "#ff0000";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Red;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void RosyBrown()
    {
        const byte expectedRed = 188;
        const byte expectedGreen = 143;
        const byte expectedBlue = 143;

        const string expectedHex = "#bc8f8f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.RosyBrown;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void RoyalBlue()
    {
        const byte expectedRed = 65;
        const byte expectedGreen = 105;
        const byte expectedBlue = 225;

        const string expectedHex = "#4169e1";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.RoyalBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SaddleBrown()
    {
        const byte expectedRed = 139;
        const byte expectedGreen = 69;
        const byte expectedBlue = 19;

        const string expectedHex = "#8b4513";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SaddleBrown;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Salmon()
    {
        const byte expectedRed = 250;
        const byte expectedGreen = 128;
        const byte expectedBlue = 114;

        const string expectedHex = "#fa8072";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Salmon;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SandyBrown()
    {
        const byte expectedRed = 244;
        const byte expectedGreen = 164;
        const byte expectedBlue = 96;

        const string expectedHex = "#f4a460";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SandyBrown;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SeaGreen()
    {
        const byte expectedRed = 46;
        const byte expectedGreen = 139;
        const byte expectedBlue = 87;

        const string expectedHex = "#2e8b57";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SeaGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SeaShell()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 245;
        const byte expectedBlue = 238;

        const string expectedHex = "#fff5ee";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SeaShell;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Sienna()
    {
        const byte expectedRed = 160;
        const byte expectedGreen = 82;
        const byte expectedBlue = 45;

        const string expectedHex = "#a0522d";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Sienna;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Silver()
    {
        const byte expectedRed = 192;
        const byte expectedGreen = 192;
        const byte expectedBlue = 192;

        const string expectedHex = "#c0c0c0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Silver;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SkyBlue()
    {
        const byte expectedRed = 135;
        const byte expectedGreen = 206;
        const byte expectedBlue = 235;

        const string expectedHex = "#87ceeb";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SkyBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SlateBlue()
    {
        const byte expectedRed = 106;
        const byte expectedGreen = 90;
        const byte expectedBlue = 205;

        const string expectedHex = "#6a5acd";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SlateBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SlateGray()
    {
        const byte expectedRed = 112;
        const byte expectedGreen = 128;
        const byte expectedBlue = 144;

        const string expectedHex = "#708090";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SlateGray;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Snow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 250;
        const byte expectedBlue = 250;

        const string expectedHex = "#fffafa";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Snow;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SpringGreen()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 255;
        const byte expectedBlue = 127;

        const string expectedHex = "#00ff7f";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SpringGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void SteelBlue()
    {
        const byte expectedRed = 70;
        const byte expectedGreen = 130;
        const byte expectedBlue = 180;

        const string expectedHex = "#4682b4";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.SteelBlue;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Tan()
    {
        const byte expectedRed = 210;
        const byte expectedGreen = 180;
        const byte expectedBlue = 140;

        const string expectedHex = "#d2b48c";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Tan;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Teal()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 128;
        const byte expectedBlue = 128;

        const string expectedHex = "#008080";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Teal;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Thistle()
    {
        const byte expectedRed = 216;
        const byte expectedGreen = 191;
        const byte expectedBlue = 216;

        const string expectedHex = "#d8bfd8";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Thistle;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Tomato()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 99;
        const byte expectedBlue = 71;

        const string expectedHex = "#ff6347";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Tomato;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Turquoise()
    {
        const byte expectedRed = 64;
        const byte expectedGreen = 224;
        const byte expectedBlue = 208;

        const string expectedHex = "#40e0d0";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Turquoise;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Violet()
    {
        const byte expectedRed = 238;
        const byte expectedGreen = 130;
        const byte expectedBlue = 238;

        const string expectedHex = "#ee82ee";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Violet;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Wheat()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 222;
        const byte expectedBlue = 179;

        const string expectedHex = "#f5deb3";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Wheat;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void White()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 255;

        const string expectedHex = "#ffffff";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.White;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void WhiteSmoke()
    {
        const byte expectedRed = 245;
        const byte expectedGreen = 245;
        const byte expectedBlue = 245;

        const string expectedHex = "#f5f5f5";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.WhiteSmoke;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void Yellow()
    {
        const byte expectedRed = 255;
        const byte expectedGreen = 255;
        const byte expectedBlue = 0;

        const string expectedHex = "#ffff00";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.Yellow;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }

    [Fact]
    public void YellowGreen()
    {
        const byte expectedRed = 154;
        const byte expectedGreen = 205;
        const byte expectedBlue = 50;

        const string expectedHex = "#9acd32";

        GifHarness.Components.Colors.Color color =
            GifHarness.Components.Colors.Color.YellowGreen;

        Assert.Equal(expectedHex,
            color.ToRgbColorString(includeHash: true, useUppercase: false));

        Assert.Equal(expectedRed, color.RedComponent);
        Assert.Equal(expectedGreen, color.GreenComponent);
        Assert.Equal(expectedBlue, color.BlueComponent);
    }
}