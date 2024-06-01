// ReSharper disable SuspiciousTypeConversion.Global

namespace Tests.Components.Header.Version;

public class Equals
{
    [Fact]
    public void V87_Manual_Objects()
    {
        DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        DateOnly wrongDate = new(1989, 1, 1);

        GifHarness.Components.Header.Version v89Version =
            new(wrongDate, version);
        GifHarness.Components.Header.Version v87Version =
            new(date, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.True(versionObject.Equals(v87Version));
        Assert.False(versionObject.Equals(v89Version));
        Assert.True(versionObject.Equals(v87VersionAuto));
        Assert.False(versionObject.Equals(v89VersionAuto));
    }

    [Fact]
    public void V89_Manual_Objects()
    {
        DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        DateOnly wrongDate = new(1987, 1, 1);

        GifHarness.Components.Header.Version v87Version =
            new(wrongDate, version);
        GifHarness.Components.Header.Version v89Version =
            new(date, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.False(versionObject.Equals(v87Version));
        Assert.True(versionObject.Equals(v89Version));
        Assert.False(versionObject.Equals(v87VersionAuto));
        Assert.True(versionObject.Equals(v89VersionAuto));
    }

    [Fact]
    public void V87_Auto_Objects()
    {
        GifHarness.Components.Header.Version versionObject =
            GifHarness.Components.Header.Version.V87A;

        DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v87Version =
            new(date, version);

        DateOnly wrongDate = new(1989, 1, 1);
        GifHarness.Components.Header.Version v89Version =
            new(wrongDate, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.True(versionObject.Equals(v87Version));
        Assert.True(versionObject.Equals(v87VersionAuto));
        Assert.False(versionObject.Equals(v89VersionAuto));
        Assert.False(versionObject.Equals(v89Version));
    }

    [Fact]
    public void V89_Auto_Objects()
    {
        GifHarness.Components.Header.Version versionObject =
            GifHarness.Components.Header.Version.V89A;

        DateOnly date = new(1989, 1, 1);
        const char version = 'a';


        DateOnly wrongDate = new(1987, 1, 1);
        GifHarness.Components.Header.Version v89Version =
            new(date, version);
        GifHarness.Components.Header.Version v87Version =
            new(wrongDate, version);

        GifHarness.Components.Header.Version v87VersionAuto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89VersionAuto =
            GifHarness.Components.Header.Version.V89A;

        Assert.False(versionObject.Equals(v87Version));
        Assert.False(versionObject.Equals(v87VersionAuto));
        Assert.True(versionObject.Equals(v89VersionAuto));
        Assert.True(versionObject.Equals(v89Version));
    }

    [Fact]
    public void V87_Dates()
    {
        DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        DateOnly wrongDate89 = new(1989, 1, 1);

        DateOnly wrongDateMonth = new(1987, 2, 1);
        DateOnly wrongDateDay = new(1987, 1, 2);

        DateOnly wrongDateYear = new(1988, 1, 1);
        DateOnly wrongDate = new(1434, 1, 1);
        DateOnly wrongDateZero = new(1, 1, 1);

        Assert.True(versionObject.Equals(date));
        Assert.True(v87Auto.Equals(date));

        Assert.False(versionObject.Equals(wrongDate89));
        Assert.False(v87Auto.Equals(wrongDate89));

        Assert.False(versionObject.Equals(wrongDateMonth));
        Assert.False(v87Auto.Equals(wrongDateMonth));

        Assert.False(versionObject.Equals(wrongDateDay));
        Assert.False(v87Auto.Equals(wrongDateDay));

        Assert.False(versionObject.Equals(wrongDateYear));
        Assert.False(v87Auto.Equals(wrongDateYear));

        Assert.False(versionObject.Equals(wrongDate));
        Assert.False(v87Auto.Equals(wrongDate));

        Assert.False(versionObject.Equals(wrongDateZero));
        Assert.False(v87Auto.Equals(wrongDateZero));
    }

    [Fact]
    public void V89_Dates()
    {
        DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version versionObject =
            new(date, version);

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        DateOnly wrongDate87 = new(1987, 1, 1);

        DateOnly wrongDateMonth = new(1989, 2, 1);
        DateOnly wrongDateDay = new(1989, 1, 2);

        DateOnly wrongDateYear = new(1988, 1, 1);
        DateOnly wrongDate = new(1434, 1, 1);
        DateOnly wrongDateZero = new(1, 1, 1);

        Assert.True(versionObject.Equals(date));
        Assert.True(v89Auto.Equals(date));

        Assert.False(versionObject.Equals(wrongDate87));
        Assert.False(v89Auto.Equals(wrongDate87));

        Assert.False(versionObject.Equals(wrongDateMonth));
        Assert.False(v89Auto.Equals(wrongDateMonth));

        Assert.False(versionObject.Equals(wrongDateDay));
        Assert.False(v89Auto.Equals(wrongDateDay));

        Assert.False(versionObject.Equals(wrongDateYear));
        Assert.False(v89Auto.Equals(wrongDateYear));

        Assert.False(versionObject.Equals(wrongDate));
        Assert.False(v89Auto.Equals(wrongDate));

        Assert.False(versionObject.Equals(wrongDateZero));
        Assert.False(v89Auto.Equals(wrongDateZero));
    }

    [Fact]
    public void V87_DateTime()
    {
        DateOnly dateNotTime = new(1987, 1, 1);
        const char version = 'a';

        DateTime date = new(1987, 1, 1, 0, 0, 0);

        GifHarness.Components.Header.Version versionObject =
            new(dateNotTime, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        DateTime wrongDate89 = new(1989, 1, 1, 0, 0, 0);

        DateTime wrongDateMonth = new(1987, 2, 1, 0, 0, 0);
        DateTime wrongDateDay = new(1987, 1, 2, 0, 0, 0);
        DateTime wrongDateHour = new(1987, 1, 1, 1, 0, 0);
        DateTime wrongDateMinute = new(1987, 1, 1, 0, 1, 0);
        DateTime wrongDateSecond = new(1987, 1, 1, 0, 0, 1);

        DateTime wrongDateYear = new(1988, 1, 1, 0, 0, 0);
        DateTime wrongDate = new(1434, 1, 1, 0, 0, 0);
        DateTime wrongDateZero = new(1, 1, 1, 0, 0, 0);

        Assert.True(versionObject.Equals(date));
        Assert.True(v87Auto.Equals(date));

        Assert.False(versionObject.Equals(wrongDate89));
        Assert.False(v87Auto.Equals(wrongDate89));

        Assert.False(versionObject.Equals(wrongDateMonth));
        Assert.False(v87Auto.Equals(wrongDateMonth));

        Assert.False(versionObject.Equals(wrongDateDay));
        Assert.False(v87Auto.Equals(wrongDateDay));

        Assert.False(versionObject.Equals(wrongDateHour));
        Assert.False(v87Auto.Equals(wrongDateHour));

        Assert.False(versionObject.Equals(wrongDateMinute));
        Assert.False(v87Auto.Equals(wrongDateMinute));

        Assert.False(versionObject.Equals(wrongDateSecond));
        Assert.False(v87Auto.Equals(wrongDateSecond));

        Assert.False(versionObject.Equals(wrongDateYear));
        Assert.False(v87Auto.Equals(wrongDateYear));

        Assert.False(versionObject.Equals(wrongDate));
        Assert.False(v87Auto.Equals(wrongDate));

        Assert.False(versionObject.Equals(wrongDateZero));
        Assert.False(v87Auto.Equals(wrongDateZero));
    }

    [Fact]
    public void V89_DateTime()
    {
        DateOnly dateNotTime = new(1989, 1, 1);
        const char version = 'a';

        DateTime date = new(1989, 1, 1, 0, 0, 0);

        GifHarness.Components.Header.Version versionObject =
            new(dateNotTime, version);

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        DateTime wrongDate87 = new(1987, 1, 1, 0, 0, 0);

        DateTime wrongDateMonth = new(1989, 2, 1, 0, 0, 0);
        DateTime wrongDateDay = new(1989, 1, 2, 0, 0, 0);
        DateTime wrongDateHour = new(1989, 1, 1, 1, 0, 0);
        DateTime wrongDateMinute = new(1989, 1, 1, 0, 1, 0);
        DateTime wrongDateSecond = new(1989, 1, 1, 0, 0, 1);

        DateTime wrongDateYear = new(1988, 1, 1, 0, 0, 0);
        DateTime wrongDate = new(1434, 1, 1, 0, 0, 0);
        DateTime wrongDateZero = new(1, 1, 1, 0, 0, 0);

        Assert.True(versionObject.Equals(date));
        Assert.True(v89Auto.Equals(date));

        Assert.False(versionObject.Equals(wrongDate87));
        Assert.False(v89Auto.Equals(wrongDate87));

        Assert.False(versionObject.Equals(wrongDateMonth));
        Assert.False(v89Auto.Equals(wrongDateMonth));

        Assert.False(versionObject.Equals(wrongDateDay));
        Assert.False(v89Auto.Equals(wrongDateDay));

        Assert.False(versionObject.Equals(wrongDateHour));
        Assert.False(v89Auto.Equals(wrongDateHour));

        Assert.False(versionObject.Equals(wrongDateMinute));
        Assert.False(v89Auto.Equals(wrongDateMinute));

        Assert.False(versionObject.Equals(wrongDateSecond));
        Assert.False(v89Auto.Equals(wrongDateSecond));

        Assert.False(versionObject.Equals(wrongDateYear));
        Assert.False(v89Auto.Equals(wrongDateYear));

        Assert.False(versionObject.Equals(wrongDate));
        Assert.False(v89Auto.Equals(wrongDate));

        Assert.False(versionObject.Equals(wrongDateZero));
        Assert.False(v89Auto.Equals(wrongDateZero));
    }

    [Fact]
    public void V87_Bytes()
    {
        DateOnly date = new(1987, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v87Manual =
            new(date, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;


        byte[] v87Bytes =
        [
            0x38, 0x37, 0x61
        ];

        byte[] v89Bytes =
        [
            0x38, 0x39, 0x61
        ];

        byte[] wrongYear =
        [
            0x38, 0x38, 0x61
        ];

        byte[] badlyFormedYear =
        [
            0x38, 0x2f, 0x61
        ];

        byte[] notAVersion =
        [
            0x38, 0x37, 0x62
        ];

        byte[] wrongVersion =
        [
            0x38, 0x37, 0x62
        ];

        byte[] controlCharacter =
        [
            0x38, 0x00, 0x61
        ];

        byte[] empty = [];

        byte[] tooShort =
        [
            0x38, 0x37
        ];

        byte[] tooLong =
        [
            0x38, 0x37, 0x61, 0x00
        ];

        Assert.True(v87Manual.Equals(v87Bytes));
        Assert.True(v87Auto.Equals(v87Bytes));

        Assert.False(v87Manual.Equals(v89Bytes));
        Assert.False(v87Auto.Equals(v89Bytes));

        Assert.False(v87Manual.Equals(wrongYear));
        Assert.False(v87Auto.Equals(wrongYear));

        Assert.False(v87Manual.Equals(badlyFormedYear));
        Assert.False(v87Auto.Equals(badlyFormedYear));

        Assert.False(v87Manual.Equals(notAVersion));
        Assert.False(v87Auto.Equals(notAVersion));

        Assert.False(v87Manual.Equals(wrongVersion));
        Assert.False(v87Auto.Equals(wrongVersion));

        Assert.False(v87Manual.Equals(controlCharacter));
        Assert.False(v87Auto.Equals(controlCharacter));

        Assert.False(v87Manual.Equals(empty));
        Assert.False(v87Auto.Equals(empty));

        Assert.False(v87Manual.Equals(tooShort));
        Assert.False(v87Auto.Equals(tooShort));

        Assert.False(v87Manual.Equals(tooLong));
        Assert.False(v87Auto.Equals(tooLong));
    }

    [Fact]
    public void V89_Bytes()
    {
        DateOnly date = new(1989, 1, 1);
        const char version = 'a';

        GifHarness.Components.Header.Version v89Manual =
            new(date, version);

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        byte[] v87Bytes =
        [
            0x38, 0x37, 0x61
        ];

        byte[] v89Bytes =
        [
            0x38, 0x39, 0x61
        ];

        byte[] wrongYear =
        [
            0x38, 0x38, 0x61
        ];

        byte[] badlyFormedYear =
        [
            0x38, 0x2f, 0x61
        ];

        byte[] notAVersion =
        [
            0x38, 0x37, 0x62
        ];

        byte[] wrongVersion =
        [
            0x38, 0x37, 0x62
        ];

        byte[] controlCharacter =
        [
            0x38, 0x00, 0x61
        ];

        byte[] empty = [];

        byte[] tooShort =
        [
            0x38, 0x37
        ];

        byte[] tooLong =
        [
            0x38, 0x37, 0x61, 0x00
        ];

        Assert.False(v89Manual.Equals(v87Bytes));
        Assert.False(v89Auto.Equals(v87Bytes));

        Assert.True(v89Manual.Equals(v89Bytes));
        Assert.True(v89Auto.Equals(v89Bytes));

        Assert.False(v89Manual.Equals(wrongYear));
        Assert.False(v89Auto.Equals(wrongYear));

        Assert.False(v89Manual.Equals(badlyFormedYear));
        Assert.False(v89Auto.Equals(badlyFormedYear));

        Assert.False(v89Manual.Equals(notAVersion));
        Assert.False(v89Auto.Equals(notAVersion));

        Assert.False(v89Manual.Equals(wrongVersion));
        Assert.False(v89Auto.Equals(wrongVersion));

        Assert.False(v89Manual.Equals(controlCharacter));
        Assert.False(v89Auto.Equals(controlCharacter));

        Assert.False(v89Manual.Equals(empty));
        Assert.False(v89Auto.Equals(empty));

        Assert.False(v89Manual.Equals(tooShort));
        Assert.False(v89Auto.Equals(tooShort));

        Assert.False(v89Manual.Equals(tooLong));
        Assert.False(v89Auto.Equals(tooLong));
    }

    [Fact]
    public void RandomObjects()
    {
        DateOnly v87Date = new(1987, 1, 1);
        DateOnly v89Date = new(1989, 1, 1);

        const char version = 'a';

        GifHarness.Components.Header.Version v87Manual =
            new(v87Date, version);

        GifHarness.Components.Header.Version v89Manual =
            new(v89Date, version);

        GifHarness.Components.Header.Version v87Auto =
            GifHarness.Components.Header.Version.V87A;

        GifHarness.Components.Header.Version v89Auto =
            GifHarness.Components.Header.Version.V89A;

        const int randomInt = 1234;
        const string randomString = "random";
        const string emptyString = "";
        object randomObject = new();
        const object? nullObject = null;

        Assert.False(v87Manual.Equals(randomInt));
        Assert.False(v87Manual.Equals(randomString));
        Assert.False(v87Manual.Equals(emptyString));
        Assert.False(v87Manual.Equals(randomObject));
        Assert.False(v87Manual.Equals(nullObject));

        Assert.False(v89Manual.Equals(randomInt));
        Assert.False(v89Manual.Equals(randomString));
        Assert.False(v89Manual.Equals(emptyString));
        Assert.False(v89Manual.Equals(randomObject));
        Assert.False(v89Manual.Equals(nullObject));

        Assert.False(v87Auto.Equals(randomInt));
        Assert.False(v87Auto.Equals(randomString));
        Assert.False(v87Auto.Equals(emptyString));
        Assert.False(v87Auto.Equals(randomObject));
        Assert.False(v87Auto.Equals(nullObject));

        Assert.False(v89Auto.Equals(randomInt));
        Assert.False(v89Auto.Equals(randomString));
        Assert.False(v89Auto.Equals(emptyString));
        Assert.False(v89Auto.Equals(randomObject));
        Assert.False(v89Auto.Equals(nullObject));
    }
}