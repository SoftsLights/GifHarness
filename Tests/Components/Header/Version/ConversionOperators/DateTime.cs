namespace Tests.Components.Header.Version.ConversionOperators;

public class DateTime
{
    [Fact]
    public void V87()
    {
        System.DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v87Manual =
            new(date, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        System.DateTime correctDate = new(1987, 1, 1, 0, 0, 0);

        System.DateTime v87DateTime = (System.DateTime)v87Manual;
        System.DateTime v87DateTimeAuto = (System.DateTime)v87Auto;

        Assert.Equal(correctDate, v87DateTime);
        Assert.Equal(correctDate, v87DateTimeAuto);
    }

    [Fact]
    public void V89()
    {
        System.DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v89Manual =
            new(date, version);

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        System.DateTime correctDate = new(1989, 1, 1, 0, 0, 0);

        System.DateTime v89DateTime = (System.DateTime)v89Manual;
        System.DateTime v89DateTimeAuto = (System.DateTime)v89Auto;

        Assert.Equal(correctDate, v89DateTime);
        Assert.Equal(correctDate, v89DateTimeAuto);
    }
}