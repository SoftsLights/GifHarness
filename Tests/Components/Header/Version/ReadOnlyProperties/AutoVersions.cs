namespace Tests.Components.Header.Version.ReadOnlyProperties;

public class AutoVersions
{
    [Fact]
    public void V87_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V87A;

        const int expectedYear = 1987;
        const int expectedMonth = 1;
        const int expectedDay = 1;

        const char expectedVersion = 'a';

        Assert.Equal(expectedYear, version.Year.Year);
        Assert.Equal(expectedMonth, version.Year.Month);
        Assert.Equal(expectedDay, version.Year.Day);

        Assert.Equal(expectedVersion, version.Letter);
    }

    [Fact]
    public void V89_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V89A;

        const int expectedYear = 1989;
        const int expectedMonth = 1;
        const int expectedDay = 1;

        const char expectedVersion = 'a';

        Assert.Equal(expectedYear, version.Year.Year);
        Assert.Equal(expectedMonth, version.Year.Month);
        Assert.Equal(expectedDay, version.Year.Day);

        Assert.Equal(expectedVersion, version.Letter);
    }
}