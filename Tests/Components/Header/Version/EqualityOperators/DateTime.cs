namespace Tests.Components.Header.Version.EqualityOperators;

public class DateTime
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

        System.DateTime correctDate = new(1987, 1, 1, 0, 0, 0);

        System.DateTime wrongDate89 = new(1989, 1, 1, 0, 0, 0);

        System.DateTime wrongDateMonth = new(1987, 2, 1, 0, 0, 0);
        System.DateTime wrongDateDay = new(1987, 1, 2, 0, 0, 0);
        System.DateTime wrongDateHour = new(1987, 1, 1, 1, 0, 0);
        System.DateTime wrongDateMinute = new(1987, 1, 1, 0, 1, 0);
        System.DateTime wrongDateSecond = new(1987, 1, 1, 0, 0, 1);
        System.DateTime wrongDateMillisecond = new(1987, 1, 1, 0, 0, 0, 1);

        System.DateTime wrongDateYear = new(1988, 1, 1, 0, 0, 0);
        System.DateTime wrongDate = new(1434, 1, 1, 0, 0, 0);
        System.DateTime wrongDateZero = new(1, 1, 1, 0, 0, 0);

        Assert.True(versionObject == correctDate);
        Assert.False(versionObject != correctDate);
        Assert.True(v87Auto == correctDate);
        Assert.False(v87Auto != correctDate);
        Assert.True(correctDate == versionObject);
        Assert.False(correctDate != versionObject);
        Assert.True(correctDate == v87Auto);
        Assert.False(correctDate != v87Auto);

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

        Assert.False(versionObject == wrongDateHour);
        Assert.True(versionObject != wrongDateHour);
        Assert.False(v87Auto == wrongDateHour);
        Assert.True(v87Auto != wrongDateHour);
        Assert.False(wrongDateHour == versionObject);
        Assert.True(wrongDateHour != versionObject);
        Assert.False(wrongDateHour == v87Auto);
        Assert.True(wrongDateHour != v87Auto);

        Assert.False(versionObject == wrongDateMinute);
        Assert.True(versionObject != wrongDateMinute);
        Assert.False(v87Auto == wrongDateMinute);
        Assert.True(v87Auto != wrongDateMinute);
        Assert.False(wrongDateMinute == versionObject);
        Assert.True(wrongDateMinute != versionObject);
        Assert.False(wrongDateMinute == v87Auto);
        Assert.True(wrongDateMinute != v87Auto);

        Assert.False(versionObject == wrongDateSecond);
        Assert.True(versionObject != wrongDateSecond);
        Assert.False(v87Auto == wrongDateSecond);
        Assert.True(v87Auto != wrongDateSecond);
        Assert.False(wrongDateSecond == versionObject);
        Assert.True(wrongDateSecond != versionObject);
        Assert.False(wrongDateSecond == v87Auto);
        Assert.True(wrongDateSecond != v87Auto);

        Assert.False(versionObject == wrongDateMillisecond);
        Assert.True(versionObject != wrongDateMillisecond);
        Assert.False(v87Auto == wrongDateMillisecond);
        Assert.True(v87Auto != wrongDateMillisecond);
        Assert.False(wrongDateMillisecond == versionObject);
        Assert.True(wrongDateMillisecond != versionObject);
        Assert.False(wrongDateMillisecond == v87Auto);
        Assert.True(wrongDateMillisecond != v87Auto);

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

        System.DateTime correctDate = new(1989, 1, 1, 0, 0, 0);

        System.DateTime wrongDate87 = new(1987, 1, 1, 0, 0, 0);

        System.DateTime wrongDateMonth = new(1987, 2, 1, 0, 0, 0);
        System.DateTime wrongDateDay = new(1987, 1, 2, 0, 0, 0);
        System.DateTime wrongDateHour = new(1987, 1, 1, 1, 0, 0);
        System.DateTime wrongDateMinute = new(1987, 1, 1, 0, 1, 0);
        System.DateTime wrongDateSecond = new(1987, 1, 1, 0, 0, 1);
        System.DateTime wrongDateMillisecond = new(1987, 1, 1, 0, 0, 0, 1);

        System.DateTime wrongDateYear = new(1988, 1, 1, 0, 0, 0);
        System.DateTime wrongDate = new(1434, 1, 1, 0, 0, 0);
        System.DateTime wrongDateZero = new(1, 1, 1, 0, 0, 0);

        Assert.True(versionObject == correctDate);
        Assert.False(versionObject != correctDate);
        Assert.True(v89Auto == correctDate);
        Assert.False(v89Auto != correctDate);
        Assert.True(correctDate == versionObject);
        Assert.False(correctDate != versionObject);
        Assert.True(correctDate == v89Auto);
        Assert.False(correctDate != v89Auto);

        Assert.False(versionObject == wrongDate87);
        Assert.True(versionObject != wrongDate87);
        Assert.False(v89Auto == wrongDate87);
        Assert.True(v89Auto != wrongDate87);
        Assert.False(wrongDate87 == versionObject);
        Assert.True(wrongDate87 != versionObject);
        Assert.False(wrongDate87 == v89Auto);
        Assert.True(wrongDate87 != v89Auto);

        Assert.False(versionObject == wrongDateMonth);
        Assert.True(versionObject != wrongDateMonth);
        Assert.False(v89Auto == wrongDateMonth);
        Assert.True(v89Auto != wrongDateMonth);
        Assert.False(wrongDateMonth == versionObject);
        Assert.True(wrongDateMonth != versionObject);
        Assert.False(wrongDateMonth == v89Auto);
        Assert.True(wrongDateMonth != v89Auto);

        Assert.False(versionObject == wrongDateDay);
        Assert.True(versionObject != wrongDateDay);
        Assert.False(v89Auto == wrongDateDay);
        Assert.True(v89Auto != wrongDateDay);
        Assert.False(wrongDateDay == versionObject);
        Assert.True(wrongDateDay != versionObject);
        Assert.False(wrongDateDay == v89Auto);
        Assert.True(wrongDateDay != v89Auto);

        Assert.False(versionObject == wrongDateHour);
        Assert.True(versionObject != wrongDateHour);
        Assert.False(v89Auto == wrongDateHour);
        Assert.True(v89Auto != wrongDateHour);
        Assert.False(wrongDateHour == versionObject);
        Assert.True(wrongDateHour != versionObject);
        Assert.False(wrongDateHour == v89Auto);
        Assert.True(wrongDateHour != v89Auto);

        Assert.False(versionObject == wrongDateMinute);
        Assert.True(versionObject != wrongDateMinute);
        Assert.False(v89Auto == wrongDateMinute);
        Assert.True(v89Auto != wrongDateMinute);
        Assert.False(wrongDateMinute == versionObject);
        Assert.True(wrongDateMinute != versionObject);
        Assert.False(wrongDateMinute == v89Auto);
        Assert.True(wrongDateMinute != v89Auto);

        Assert.False(versionObject == wrongDateSecond);
        Assert.True(versionObject != wrongDateSecond);
        Assert.False(v89Auto == wrongDateSecond);
        Assert.True(v89Auto != wrongDateSecond);
        Assert.False(wrongDateSecond == versionObject);
        Assert.True(wrongDateSecond != versionObject);
        Assert.False(wrongDateSecond == v89Auto);
        Assert.True(wrongDateSecond != v89Auto);

        Assert.False(versionObject == wrongDateMillisecond);
        Assert.True(versionObject != wrongDateMillisecond);
        Assert.False(v89Auto == wrongDateMillisecond);
        Assert.True(v89Auto != wrongDateMillisecond);
        Assert.False(wrongDateMillisecond == versionObject);
        Assert.True(wrongDateMillisecond != versionObject);
        Assert.False(wrongDateMillisecond == v89Auto);
        Assert.True(wrongDateMillisecond != v89Auto);

        Assert.False(versionObject == wrongDateYear);
        Assert.True(versionObject != wrongDateYear);
        Assert.False(v89Auto == wrongDateYear);
        Assert.True(v89Auto != wrongDateYear);
        Assert.False(wrongDateYear == versionObject);
        Assert.True(wrongDateYear != versionObject);
        Assert.False(wrongDateYear == v89Auto);
        Assert.True(wrongDateYear != v89Auto);

        Assert.False(versionObject == wrongDate);
        Assert.True(versionObject != wrongDate);
        Assert.False(v89Auto == wrongDate);
        Assert.True(v89Auto != wrongDate);
        Assert.False(wrongDate == versionObject);
        Assert.True(wrongDate != versionObject);
        Assert.False(wrongDate == v89Auto);
        Assert.True(wrongDate != v89Auto);

        Assert.False(versionObject == wrongDateZero);
        Assert.True(versionObject != wrongDateZero);
        Assert.False(v89Auto == wrongDateZero);
        Assert.True(v89Auto != wrongDateZero);
        Assert.False(wrongDateZero == versionObject);
        Assert.True(wrongDateZero != versionObject);
        Assert.False(wrongDateZero == v89Auto);
        Assert.True(wrongDateZero != v89Auto);
    }
}