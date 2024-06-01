namespace Tests.Components.Header.Version;

public class ToString
{
    [Fact]
    public void V87_Manual()
    {
        const string expectedString = "Gif Version 87a";

        DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version headerVersion =
            new(date, version);

        string actualString = headerVersion.ToString();

        Assert.Equal(expectedString, actualString);
    }

    [Fact]
    public void V89_Manual()
    {
        const string expectedString = "Gif Version 89a";

        DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version headerVersion =
            new(date, version);

        string actualString = headerVersion.ToString();

        Assert.Equal(expectedString, actualString);
    }

    [Fact]
    public void V87_Auto()
    {
        const string expectedString = "Gif Version 87a";

        GifHarness.Components.Header.Version headerVersion =
            GifHarness.Components.Header.Version.V87A;

        string actualString = headerVersion.ToString();

        Assert.Equal(expectedString, actualString);
    }

    [Fact]
    public void V89_Auto()
    {
        const string expectedString = "Gif Version 89a";

        GifHarness.Components.Header.Version headerVersion =
            GifHarness.Components.Header.Version.V89A;

        string actualString = headerVersion.ToString();

        Assert.Equal(expectedString, actualString);
    }
}