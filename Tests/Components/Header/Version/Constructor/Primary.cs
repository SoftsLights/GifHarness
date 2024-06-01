namespace Tests.Components.Header.Version.Constructor;

public class Primary
{
    [Fact]
    public void V87A_Good()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedDate, version.Year);
        Assert.Equal(expectedVersion, version.Letter);

        Assert.True(version.IsV87A);
        Assert.False(version.IsV89A);
    }

    [Fact]
    public void V89A_Good()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        Assert.Equal(expectedDate, version.Year);
        Assert.Equal(expectedVersion, version.Letter);

        Assert.False(version.IsV87A);
        Assert.True(version.IsV89A);
    }

    [Fact]
    public void BadYear()
    {
        DateOnly expectedDate = new(1988, 1, 1);
        const char expectedVersion = 'a';

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }

    [Fact]
    public void Bad_NotJanuary1st()
    {
        DateOnly expectedDate = new(1987, 1, 2);
        const char expectedVersion = 'a';

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }

    [Fact]
    public void Bad_NotJanuary1st_2()
    {
        DateOnly expectedDate = new(1987, 2, 1);
        const char expectedVersion = 'a';

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }

    [Fact]
    public void Bad_NotAVersion()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'b';

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }

    [Fact]
    public void Bad_Version()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'A';

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }

    [Fact]
    public void Bad_ControlCharacter()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = '\0';

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                new(expectedDate, expectedVersion);
        });
    }
}