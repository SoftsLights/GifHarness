namespace Tests.Components.Header.Version.EqualityOperators;

public class Version
{
    [Fact]
    public void V87_Manual_Objects()
    {
        System.DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        System.DateOnly wrongDate = new(1989, 1, 1);

        GifHarness.Components.Header.Version v89Version =
            new(wrongDate, version);
        GifHarness.Components.Header.Version v87Version =
            new(date, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.True(versionObject == v87Version);
        Assert.False(versionObject != v87Version);

        Assert.False(versionObject == v89Version);
        Assert.True(versionObject != v89Version);

        Assert.True(versionObject == v87VersionAuto);
        Assert.False(versionObject != v87VersionAuto);

        Assert.False(versionObject == v89VersionAuto);
        Assert.True(versionObject != v89VersionAuto);
    }

    [Fact]
    public void V89_Manual_Objects()
    {
        System.DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        System.DateOnly wrongDate = new(1987, 1, 1);

        GifHarness.Components.Header.Version v87Version =
            new(wrongDate, version);
        GifHarness.Components.Header.Version v89Version =
            new(date, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.False(versionObject == v87Version);
        Assert.True(versionObject != v87Version);

        Assert.True(versionObject == v89Version);
        Assert.False(versionObject != v89Version);

        Assert.False(versionObject == v87VersionAuto);
        Assert.True(versionObject != v87VersionAuto);

        Assert.True(versionObject == v89VersionAuto);
        Assert.False(versionObject != v89VersionAuto);
    }

    [Fact]
    public void V87_Auto_Objects()
    {
        GifHarness.Components.Header.Version versionObject =
            GifHarness.Components.Header.Version.V87A;

        System.DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v87Version =
            new(date, version);

        System.DateOnly wrongDate = new(1989, 1, 1);
        GifHarness.Components.Header.Version v89Version =
            new(wrongDate, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.True(versionObject == v87Version);
        Assert.False(versionObject != v87Version);

        Assert.False(versionObject == v89Version);
        Assert.True(versionObject != v89Version);

        Assert.True(versionObject == v87VersionAuto);
        Assert.False(versionObject != v87VersionAuto);

        Assert.False(versionObject == v89VersionAuto);
        Assert.True(versionObject != v89VersionAuto);
    }

    [Fact]
    public void V89_Auto_Objects()
    {
        GifHarness.Components.Header.Version versionObject =
            GifHarness.Components.Header.Version.V89A;

        System.DateOnly date = new(1989, 1, 1);
        const char version = 'a';


        System.DateOnly wrongDate = new(1987, 1, 1);
        GifHarness.Components.Header.Version v89Version =
            new(date, version);
        GifHarness.Components.Header.Version v87Version =
            new(wrongDate, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.False(versionObject == v87Version);
        Assert.True(versionObject != v87Version);

        Assert.True(versionObject == v89Version);
        Assert.False(versionObject != v89Version);

        Assert.False(versionObject == v87VersionAuto);
        Assert.True(versionObject != v87VersionAuto);

        Assert.True(versionObject == v89VersionAuto);
        Assert.False(versionObject != v89VersionAuto);
    }
}