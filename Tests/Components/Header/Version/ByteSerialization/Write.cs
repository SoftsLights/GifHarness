namespace Tests.Components.Header.Version.ByteSerialization;

public class Write
{
    [Fact]
    public void V87_Manual()
    {
        DateOnly expectedDate = new(1987, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        byte[] expectedBytes =
        [
            0x38, 0x37, 0x61
        ];

        byte[] actualBytes =
            GifHarness.Components.Header.Version.WriteBytes(version);


        Assert.Equal(expectedBytes, actualBytes);
    }

    [Fact]
    public void V89_Manual()
    {
        DateOnly expectedDate = new(1989, 1, 1);
        const char expectedVersion = 'a';

        GifHarness.Components.Header.Version version =
            new(expectedDate, expectedVersion);

        byte[] expectedBytes =
        [
            0x38, 0x39, 0x61
        ];

        byte[] actualBytes =
            GifHarness.Components.Header.Version.WriteBytes(version);


        Assert.Equal(expectedBytes, actualBytes);
    }

    [Fact]
    public void V87_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V87A;

        byte[] expectedBytes =
        [
            0x38, 0x37, 0x61
        ];

        byte[] actualBytes =
            GifHarness.Components.Header.Version.WriteBytes(version);


        Assert.Equal(expectedBytes, actualBytes);
    }

    [Fact]
    public void V89_Auto()
    {
        GifHarness.Components.Header.Version version =
            GifHarness.Components.Header.Version.V89A;

        byte[] expectedBytes =
        [
            0x38, 0x39, 0x61
        ];

        byte[] actualBytes =
            GifHarness.Components.Header.Version.WriteBytes(version);


        Assert.Equal(expectedBytes, actualBytes);
    }
}