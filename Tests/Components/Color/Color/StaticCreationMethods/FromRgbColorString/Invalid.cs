namespace Tests.Components.Color.Color.StaticCreationMethods.FromRgbColorString;

public class Invalid
{
    [Fact]
    public void UnrelatedString()
    {
        const string colorString = "InvalidColorString";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                colorString);
        });
    }

    [Fact]
    public void Spaces()
    {
        const string colorString = "Invalid Color String";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                colorString);
        });
    }

    [Fact]
    public void InvalidLength()
    {
        const string colorStringShort = "00000";
        const string colorStringLong = "0000000000";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                colorStringShort);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                colorStringLong);
        });
    }

    [Fact]
    public void Empty()
    {
        const string colorString = "";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                colorString);
        });
    }

    [Fact]
    public void InvalidCharacters()
    {
        const string invalidFirstCharacter = "G00000";
        const string invalidSecondCharacter = "0G0000";
        const string invalidThirdCharacter = "00G000";
        const string invalidFourthCharacter = "000G00";
        const string invalidFifthCharacter = "0000G0";
        const string invalidSixthCharacter = "00000G";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidFirstCharacter);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidSecondCharacter);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidThirdCharacter);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidFourthCharacter);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidFifthCharacter);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidSixthCharacter);
        });

        const string firstInvalidCharacterLowercase = "g00000";
        const string secondInvalidCharacterLowercase = "0g0000";
        const string thirdInvalidCharacterLowercase = "00g000";
        const string fourthInvalidCharacterLowercase = "000g00";
        const string fifthInvalidCharacterLowercase = "0000g0";
        const string sixthInvalidCharacterLowercase = "00000g";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                firstInvalidCharacterLowercase);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                secondInvalidCharacterLowercase);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                thirdInvalidCharacterLowercase);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                fourthInvalidCharacterLowercase);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                fifthInvalidCharacterLowercase);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                sixthInvalidCharacterLowercase);
        });
    }

    [Fact]
    public void NotAHash()
    {
        const string invalidNonHashCharStringNoAlpha = "G000000";
        const string invalidNonHashCharStringAlpha = "G0000000";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidNonHashCharStringNoAlpha);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidNonHashCharStringAlpha);
        });
    }

    [Fact]
    public void MixedUpAlpha()
    {
        const string invalidAlphaPosition = "#00000fF";
        const string invalidAlphaPositionAlternate = "#00000Ff";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidAlphaPosition);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidAlphaPositionAlternate);
        });

        const string invalidAlphaPositionLowercase = "#00000gG";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidAlphaPositionLowercase);
        });
    }

    [Fact]
    public void BadAlpha()
    {
        const string invalidAlpha = "#00000012";
        const string invalidAlphaAlternate = "#000000F7";

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidAlpha);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Colors.Color.FromRgbColorString(
                invalidAlphaAlternate);
        });
    }
}