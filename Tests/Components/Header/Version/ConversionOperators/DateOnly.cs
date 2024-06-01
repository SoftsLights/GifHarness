namespace Tests.Components.Header.Version.ConversionOperators;

public class DateOnly
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

        System.DateOnly correctDate = new(1987, 1, 1);

        System.DateOnly v87Date = (System.DateOnly)v87Manual;
        System.DateOnly v87DateAuto = (System.DateOnly)v87Auto;

        Assert.Equal(correctDate, v87Date);
        Assert.Equal(correctDate, v87DateAuto);
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

        System.DateOnly correctDate = new(1989, 1, 1);

        System.DateOnly v89Date = (System.DateOnly)v89Manual;
        System.DateOnly v89DateAuto = (System.DateOnly)v89Auto;

        Assert.Equal(correctDate, v89Date);
        Assert.Equal(correctDate, v89DateAuto);
    }
}