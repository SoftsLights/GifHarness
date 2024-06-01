namespace Tests.Components.Header.Version.ByteSerialization;

public class Read
{
    [Fact]
    public void V87A_Good()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        byte[] data =
        [
            0x38, 0x37, 0x61
        ];

        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.ReadBytes(data);

        Assert.Equal(expectedDate.Year, version.Year.Year);
        Assert.Equal(expectedDate.Month, version.Year.Month);
        Assert.Equal(expectedDate.Day, version.Year.Day);
        Assert.Equal(expectedVersion, version.Letter);

        Assert.True(version.IsV87A);
        Assert.False(version.IsV89A);
    }

    [Fact]
    public void V89A_Good()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        byte[] data =
        [
            0x38, 0x39, 0x61
        ];

        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.ReadBytes(data);

        Assert.Equal(expectedDate.Year, version.Year.Year);
        Assert.Equal(expectedDate.Month, version.Year.Month);
        Assert.Equal(expectedDate.Day, version.Year.Day);
        Assert.Equal(expectedVersion, version.Letter);

        Assert.False(version.IsV87A);
        Assert.True(version.IsV89A);
    }

    [Fact]
    public void BadYear()
    {
        byte[] data =
        [
            0x38, 0x38, 0x61
        ];

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(data);
        });
    }

    [Fact]
    public void Bad_MalformedYear()
    {
        byte[] badlyFormedYear =
        [
            0x38, 0x2f, 0x61
        ];

        Assert.Throws<FormatException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(badlyFormedYear);
        });
    }

    [Fact]
    public void Bad_NotAVersion()
    {
        byte[] data =
        [
            0x38, 0x37, 0x62
        ];

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(data);
        });
    }

    [Fact]
    public void Bad_Version()
    {
        byte[] data =
        [
            0x38, 0x37, 0x41
        ];

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(data);
        });
    }

    [Fact]
    public void Bad_ControlCharacter()
    {
        byte[] data =
        [
            0x38, 0x00, 0x61
        ];

        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(data);
        });
    }

    [Fact]
    public void Bad_BadLength()
    {
        byte[] empty = [];

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(empty);
        });

        byte[] tooShort = [0x38, 0x37];

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(tooShort);
        });

        byte[] tooLong = [0x38, 0x37, 0x61, 0x00];

        Assert.Throws<ArgumentException>(() =>
        {
            GifHarness.Components.Header.Version _ =
                GifHarness.Components.Header.Version.ReadBytes(tooLong);
        });
    }
}