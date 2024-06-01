namespace Tests.Components.Header.Version.EqualityOperators;

public class DateOnly
{
    [Fact]
    public void V87()
    {
        System.DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        System.DateOnly wrongDate89 = new(1989, 1, 1);

        System.DateOnly wrongDateMonth = new(1987, 2, 1);
        System.DateOnly wrongDateDay = new(1987, 1, 2);

        System.DateOnly wrongDateYear = new(1988, 1, 1);
        System.DateOnly wrongDate = new(1434, 1, 1);
        System.DateOnly wrongDateZero = new(1, 1, 1);

        Assert.True(versionObject == date);
        Assert.False(versionObject != date);
        Assert.True(v87Auto == date);
        Assert.False(v87Auto != date);
        Assert.True(date == versionObject);
        Assert.False(date != versionObject);
        Assert.True(date == v87Auto);
        Assert.False(date != v87Auto);

        Assert.False(versionObject == wrongDate89);
        Assert.True(versionObject != wrongDate89);
        Assert.False(v87Auto == wrongDate89);
        Assert.True(v87Auto != wrongDate89);
        Assert.False(wrongDate89 == versionObject);
        Assert.True(wrongDate89 != versionObject);
        Assert.False(wrongDate89 == v87Auto);
        Assert.True(wrongDate89 != v87Auto);

        Assert.False(versionObject == wrongDateMonth);
        Assert.True(versionObject != wrongDateMonth);
        Assert.False(v87Auto == wrongDateMonth);
        Assert.True(v87Auto != wrongDateMonth);
        Assert.False(wrongDateMonth == versionObject);
        Assert.True(wrongDateMonth != versionObject);
        Assert.False(wrongDateMonth == v87Auto);
        Assert.True(wrongDateMonth != v87Auto);

        Assert.False(versionObject == wrongDateDay);
        Assert.True(versionObject != wrongDateDay);
        Assert.False(v87Auto == wrongDateDay);
        Assert.True(v87Auto != wrongDateDay);
        Assert.False(wrongDateDay == versionObject);
        Assert.True(wrongDateDay != versionObject);
        Assert.False(wrongDateDay == v87Auto);
        Assert.True(wrongDateDay != v87Auto);

        Assert.False(versionObject == wrongDateYear);
        Assert.True(versionObject != wrongDateYear);
        Assert.False(v87Auto == wrongDateYear);
        Assert.True(v87Auto != wrongDateYear);
        Assert.False(wrongDateYear == versionObject);
        Assert.True(wrongDateYear != versionObject);
        Assert.False(wrongDateYear == v87Auto);
        Assert.True(wrongDateYear != v87Auto);

        Assert.False(versionObject == wrongDate);
        Assert.True(versionObject != wrongDate);
        Assert.False(v87Auto == wrongDate);
        Assert.True(v87Auto != wrongDate);
        Assert.False(wrongDate == versionObject);
        Assert.True(wrongDate != versionObject);
        Assert.False(wrongDate == v87Auto);
        Assert.True(wrongDate != v87Auto);

        Assert.False(versionObject == wrongDateZero);
        Assert.True(versionObject != wrongDateZero);
        Assert.False(v87Auto == wrongDateZero);
        Assert.True(v87Auto != wrongDateZero);
        Assert.False(wrongDateZero == versionObject);
        Assert.True(wrongDateZero != versionObject);
        Assert.False(wrongDateZero == v87Auto);
        Assert.True(wrongDateZero != v87Auto);
    }

    [Fact]
    public void V89()
    {
        System.DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        System.DateOnly wrongDate87 = new(1987, 1, 1);

        System.DateOnly wrongDateMonth = new(1989, 2, 1);
        System.DateOnly wrongDateDay = new(1989, 1, 2);

        System.DateOnly wrongDateYear = new(1988, 1, 1);
        System.DateOnly wrongDate = new(1434, 1, 1);
        System.DateOnly wrongDateZero = new(1, 1, 1);

        Assert.True(versionObject == date);
        Assert.False(versionObject != date);
        Assert.True(v89Auto == date);
        Assert.False(v89Auto != date);

        Assert.False(versionObject == wrongDate87);
        Assert.True(versionObject != wrongDate87);
        Assert.False(v89Auto == wrongDate87);
        Assert.True(v89Auto != wrongDate87);

        Assert.False(versionObject == wrongDateMonth);
        Assert.True(versionObject != wrongDateMonth);
        Assert.False(v89Auto == wrongDateMonth);
        Assert.True(v89Auto != wrongDateMonth);

        Assert.False(versionObject == wrongDateDay);
        Assert.True(versionObject != wrongDateDay);
        Assert.False(v89Auto == wrongDateDay);
        Assert.True(v89Auto != wrongDateDay);

        Assert.False(versionObject == wrongDateYear);
        Assert.True(versionObject != wrongDateYear);
        Assert.False(v89Auto == wrongDateYear);
        Assert.True(v89Auto != wrongDateYear);

        Assert.False(versionObject == wrongDate);
        Assert.True(versionObject != wrongDate);
        Assert.False(v89Auto == wrongDate);
        Assert.True(v89Auto != wrongDate);

        Assert.False(versionObject == wrongDateZero);
        Assert.True(versionObject != wrongDateZero);
        Assert.False(v89Auto == wrongDateZero);
        Assert.True(v89Auto != wrongDateZero);
    }
}