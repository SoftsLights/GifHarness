namespace Tests.Components.Header.Version.ReadOnlyProperties;

public class Letter
{
    [Fact]
    public void V87_Manual()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedVersion, version.Letter);
    }

    [Fact]
    public void V89_Manual()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedVersion, version.Letter);
    }

    [Fact]
    public void V87_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V87A;

        const char expectedVersion = 'a';

        Assert.Equal(expectedVersion, version.Letter);
    }

    [Fact]
    public void V89_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V89A;

        const char expectedVersion = 'a';

        Assert.Equal(expectedVersion, version.Letter);
    }
}