namespace Tests.Components.Header.Version.ReadOnlyProperties;

public class Year
{
    [Fact]
    public void V87_Manual()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedDate.Year, version.Year.Year);
        Assert.Equal(expectedDate.Month, version.Year.Month);
        Assert.Equal(expectedDate.Day, version.Year.Day);
    }

    [Fact]
    public void V89_Manual()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedDate.Year, version.Year.Year);
        Assert.Equal(expectedDate.Month, version.Year.Month);
        Assert.Equal(expectedDate.Day, version.Year.Day);
    }

    [Fact]
    public void V87_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V87A;

        const int expectedYear = 1987;
        const int expectedMonth = 1;
        const int expectedDay = 1;

        Assert.Equal(expectedYear, version.Year.Year);
        Assert.Equal(expectedMonth, version.Year.Month);
        Assert.Equal(expectedDay, version.Year.Day);
    }

    [Fact]
    public void V89_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V89A;

        const int expectedYear = 1989;
        const int expectedMonth = 1;
        const int expectedDay = 1;

        Assert.Equal(expectedYear, version.Year.Year);
        Assert.Equal(expectedMonth, version.Year.Month);
        Assert.Equal(expectedDay, version.Year.Day);
    }
}