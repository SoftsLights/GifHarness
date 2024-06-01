namespace Tests.Components.Header.Version;

public class HashCode
{
    [Fact]
    public void Check()
    {
        DateOnly v87Date = new(1987, 1, 1);
        DateOnly v89Date = new(1989, 1, 1);

        const char version = 'a';

        GifHarness.Components.Header.Version v87Manual = new(v87Date, version);
        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89Manual = new(v89Date, version);
        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        int v87ManualHash = v87Manual.GetHashCode();
        int v87AutoHash = v87Auto.GetHashCode();

        int v89ManualHash = v89Manual.GetHashCode();
        int v89AutoHash = v89Auto.GetHashCode();

        Assert.Equal(v87ManualHash, v87AutoHash);
        Assert.NotEqual(v87ManualHash, v89ManualHash);
        Assert.NotEqual(v87ManualHash, v89AutoHash);

        Assert.Equal(v89ManualHash, v89AutoHash);
        Assert.NotEqual(v89ManualHash, v87AutoHash);

        Assert.NotEqual(v87AutoHash, v89AutoHash);
    }
}