namespace Tests.Components.Header.Version.ReadOnlyProperties;

public class IsAVersion
{
    [Fact]
    public void V87_Manual()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.True(version.IsV87A);
        Assert.False(version.IsV89A);
    }

    [Fact]
    public void V89_Manual()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.False(version.IsV87A);
        Assert.True(version.IsV89A);
    }

    [Fact]
    public void V87_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V87A;

        Assert.True(version.IsV87A);
        Assert.False(version.IsV89A);
    }

    [Fact]
    public void V89_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V89A;

        Assert.False(version.IsV87A);
        Assert.True(version.IsV89A);
    }
}