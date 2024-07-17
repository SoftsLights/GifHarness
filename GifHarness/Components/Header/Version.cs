using System.Diagnostics;

// ReSharper disable SuspiciousTypeConversion.Global

namespace GifHarness.Components.Header;

/// <summary>
///     <para>
///         Represents the version of the GIF format
///         that a GIF file is using.
///     </para>
///
///     <para>
///         It is composed of a year and a letter.
///         The year is the year that the GIF format was created.
///     </para>
///
///     <para>
///         The letter is a lowercase letter that represents
///         the version of the GIF format.
///     </para>
///
///     <para>
///         As of now, the only valid letter is 'a'.
///     </para>
///
///     <para>
///         The only two valid years are 1987 and 1989 as of now.
///     </para>
///
///     <para>
///         The only two valid versions are 1987a and 1989a as of now.
///     </para>
/// </summary>
public sealed class Version : IByteSerializable<Version>
{
    /// <summary>
    ///     The year that the GIF format was created.
    /// </summary>
    private readonly DateOnly _year;

    /// <summary>
    ///     The letter that represents the version of the GIF format.
    /// </summary>
    private readonly char _letter;

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="Version"/> class.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be January 1st of 1987 or 1989 as of now.
    ///     </para>
    ///
    ///     <para>
    ///         The letter must be a lowercase letter between 'a' and 'z'
    ///         (inclusive)(, as of now, the only valid letter is 'a').
    ///     </para>
    /// </summary>
    /// <param name="year">
    ///     <para>
    ///         The year that the GIF format was created.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be January 1st of 1987 or 1989 as of now.
    ///     </para>
    /// </param>
    /// <param name="letter">
    ///     <para>
    ///         The letter that represents the version of the GIF format.
    ///     </para>
    ///
    ///     <para>
    ///         The letter must be a lowercase letter between 'a' and 'z' (inclusive).
    ///     </para>
    ///
    ///     <para>
    ///         As of now, the only valid letter is 'a'.
    ///     </para>
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the <paramref name="year"/> parameter is not January 1st.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the <paramref name="year"/> parameter is not 1987 or 1989.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the <paramref name="letter"/> parameter is not a lowercase letter.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown if the <paramref name="letter"/> parameter is not 'a'.
    /// </exception>
    public Version(DateOnly year, char letter)
    {
        Year = year;
        Letter = letter;
    }

    /// <summary>
    ///     <para>
    ///         The version-revision of the GIF format.
    ///     </para>
    ///
    ///     <para>
    ///         The version-revision is the letter that represents the version of the GIF format.
    ///         It is a lowercase letter between 'a' and 'z' (inclusive).
    ///     </para>
    ///
    ///     <para>
    ///         As of now, the only valid letter is 'a'.
    ///     </para>
    /// </summary>
    /// <param name="value">
    ///     <para>
    ///         The letter that represents the version of the GIF format.
    ///     </para>
    ///
    ///     <para>
    ///         The letter must be a lowercase letter between 'a' and 'z' (inclusive).
    ///     </para>
    ///
    ///     <para>
    ///         As of now, the only valid letter is 'a'.
    ///     </para>
    /// </param>
    /// <returns>
    ///     The version-revision of the GIF format.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <para>
    ///         Thrown if the letter is not a lowercase letter.
    ///     </para>
    ///
    ///     <para>
    ///         Note: the setter is an init-only property therefore
    ///         this exception is only potentially thrown when an instance
    ///         is being created.
    ///     </para>
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     <para>
    ///         Thrown if the letter is not 'a'.
    ///     </para>
    ///
    ///     <para>
    ///         Note: the setter is an init-only property therefore
    ///         this exception is only potentially thrown when an instance
    ///         is being created.
    ///     </para>
    /// </exception>
    public char Letter
    {
        get => _letter;
        init
        {
            if (value is < 'a' or > 'z')
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    "GIF version letter must be a lowercase letter.");
            }

            if (value is not 'a')
            {
                throw new ArgumentException(
                    "GIF version letter must be 'a'.\n" +
                    "(as of now, there is no other valid letter)",
                    nameof(value));
            }

            _letter = value;
        }
    }

    /// <summary>
    ///     <para>
    ///         The year that the GIF format was created.
    ///     </para>
    ///
    ///     <para>
    ///         The <see cref="DateOnly"/> object must be set to January 1st.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be 1987 or 1989 as of now.
    ///     </para>
    /// </summary>
    /// <param name="value">
    ///     <para>
    ///         The year that the GIF format was created.
    ///     </para>
    ///
    ///     <para>
    ///         The <see cref="DateOnly"/> object must be set to January 1st.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be 1987 or 1989 as of now.
    ///     </para>
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <para>
    ///         Thrown if the <see cref="DateOnly"/> object is not set to January 1st.
    ///     </para>
    ///
    ///     <para>
    ///         Note: the setter is an init-only property therefore
    ///         this exception is only potentially thrown when an instance
    ///         is being created.
    ///     </para>
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     <para>
    ///         Thrown if the year is not 1987 or 1989.
    ///     </para>
    ///
    ///     <para>
    ///         Note: the setter is an init-only property therefore
    ///         this exception is only potentially thrown when an instance
    ///         is being created.
    ///     </para>
    /// </exception>
    public DateOnly Year
    {
        get => _year;
        init
        {
            if (value.Day != 1 || value.Month != 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    "Gif Version year must be January 1st.");
            }

            if (value.Year is not 1987 and not 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    "Gif Version year must be 1987 or 1989.\n" +
                    "Indeed as of now, the only two valid years are 1987 and 1989.");
            }

            _year = value;
        }
    }

    /// <summary>
    ///     A new instance of the version of the GIF format that was created in 1987.
    /// </summary>
    /// <returns>
    ///     A newly created instance of the version of the GIF format that was created in 1987 (version 87a).
    /// </returns>
    /// <remarks>
    ///     The version is 1987a and there have been no other versions of the GIF format since.
    /// </remarks>
    public static Version V87A =>
        new(new DateOnly(1987, 1, 1), 'a');

    /// <summary>
    ///     A new instance of the version of the GIF format that was created in 1989.
    /// </summary>
    /// <returns>
    ///     A newly created instance of the version of the GIF format that was created in 1989 (version 87a).
    /// </returns>
    /// <remarks>
    ///     The version is 1989a and there have been no other versions of the GIF format since.
    /// </remarks>
    public static Version V89A =>
        new(new DateOnly(1989, 1, 1), 'a');

    /// <summary>
    ///     Checks if the version is 87a (<see cref="V87A"/>).
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the version is 87a; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsV87A => Year == new DateOnly(1987, 1, 1) && Letter == 'a';

    /// <summary>
    ///     Checks if the version is 89a (<see cref="V89A"/>).
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the version is 89a; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsV89A => Year == new DateOnly(1989, 1, 1) && Letter == 'a';

    /// <summary>
    ///     <para>
    ///         Reads a <see cref="Version"/> object from a byte array.
    ///     </para>
    ///
    ///     <para>
    ///         The byte array must be exactly 3 bytes long.
    ///     </para>
    ///
    ///     <para>
    ///         The first two bytes are the year, and the third byte is the letter.
    ///     </para>
    ///
    ///     <para>
    ///         The year is stored as the first two bytes in big-endian order.
    ///         Each byte contains an ASCII character that represents a digit.
    ///         The first byte is the decade, and the second byte is the unit.
    ///         The year is the decade and unit concatenated together.
    ///         The year is then added to 1900 to get the actual year.
    ///         (for example, if the first byte is '1' and the second byte is '9',
    ///         then the year is 1900 + 19 = 1919).
    ///     </para>
    ///
    ///     <para>
    ///         The letter is stored as the third byte.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be January 1st of a year to be a valid GIF version.
    ///         As of now, the only valid years are 1987 and 1989.
    ///     </para>
    ///
    ///     <para>
    ///         The letter must be a lowercase letter between 'a' and 'z' (inclusive).
    ///         As of now, the only valid letter is 'a'.
    ///     </para>
    /// </summary>
    /// <param name="data">
    ///     The byte array to read the <see cref="Version"/> object from.
    ///
    ///     <para>
    ///         The byte array must be exactly 3 bytes long.
    ///     </para>
    ///
    ///     <para>
    ///         The first two bytes are the year, and the third byte is the letter.
    ///     </para>
    ///
    ///     <para>
    ///         The year is stored as the first two bytes in big-endian order.
    ///         Each byte contains an ASCII character that represents a digit.
    ///         The first byte is the decade, and the second byte is the unit.
    ///         The year is the decade and unit concatenated together.
    ///         The year is then added to 1900 to get the actual year.
    ///         (for example, if the first byte is '1' and the second byte is '9',
    ///         then the year is 1900 + 19 = 1919).
    ///     </para>
    ///
    ///     <para>
    ///         The letter is stored as the third byte.
    ///     </para>
    ///
    ///     <para>
    ///         The year must be January 1st of a year to be a valid GIF version.
    ///         As of now, the only valid years are 1987 and 1989.
    ///     </para>
    ///
    ///     <para>
    ///         The letter must be a lowercase letter between 'a' and 'z' (inclusive).
    ///         As of now, the only valid letter is 'a'.
    ///     </para>
    /// </param>
    /// <returns>
    ///     The <see cref="Version"/> object that was read from the byte array.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the <paramref name="data"/> parameter is not exactly 3 bytes long.
    /// </exception>
    /// <exception cref="FormatException">
    ///     Thrown if the year string is not a valid number.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the year encoded is not January 1st.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the year encoded is not 1987 or 1989.
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if the version encoded is not a lowercase letter.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown if the version encoded parameter is not 'a'.
    /// </exception>
    public static Version ReadBytes(byte[] data)
    {
        if (data.Length != 3)
        {
            throw new ArgumentException(
                "Gif Version data must be exactly 3 bytes long.\n" +
                "The first two bytes are the year, and the third byte is the letter.",
                nameof(data));
        }

        char yearDecade = (char)data[0];
        char yearUnit = (char)data[1];

        int yearValue = int.Parse($"{yearDecade}{yearUnit}");
        yearValue += 1900;
        DateOnly year = new(yearValue, 1, 1);

        char letter = (char)data[2];
        return new Version(year, letter);
    }

    /// <summary>
    ///     Writes the <see cref="Version"/> object to a byte array.
    ///
    ///     <para>
    ///         The byte array is exactly 3 bytes long.
    ///     </para>
    ///
    ///     <para>
    ///         The first two bytes are the last two digits of the year in big-endian order as ASCII characters.
    ///         The first byte is the decade, and the second byte is the unit.
    ///         The year is the decade and unit concatenated together.
    ///         The year is then added to 1900 to get the actual year.
    ///         (for example, if the first byte is '1' and the second byte is '9',
    ///         then the year is 1900 + 19 = 1919).
    ///     </para>
    ///
    ///     <para>
    ///         The third byte is the letter that represents the version of the GIF format.
    ///         ('a' to 'z' where 'a' is the first version)
    ///     </para>
    /// </summary>
    /// <param name="version">
    ///     The <see cref="Version"/> object to write to a byte array.
    /// </param>
    /// <returns>
    ///     The byte array that represents the <see cref="Version"/> object.
    /// </returns>
    /// <exception cref="UnreachableException">
    ///     Thrown if the year is not 4 digits long.
    ///
    ///     <para>
    ///         As this is an unreachable exception, it should never be thrown.
    ///         If it is thrown, it is a bug in the code or an oversight due
    ///         to changing circumstances that were not accounted for in the future.
    ///     </para>
    /// </exception>
    public static byte[] WriteBytes(Version version)
    {
        byte[] data = new byte[3];

        string yearString = version.Year.Year.ToString();
        if (yearString.Length != 4)
        {
            throw new UnreachableException("Year must be 4 digits long.");
        }

        char secondToLastDigit = yearString[2];
        char lastDigit = yearString[3];

        data[0] = (byte)secondToLastDigit;
        data[1] = (byte)lastDigit;
        data[2] = (byte)version.Letter;
        return data;
    }

    /// <summary>
    ///     Determines whether the specified <see cref="object"/> is equal to the current <see cref="Version"/>.
    ///
    ///     <para>
    ///         If the specified <see cref="object"/> is a <see cref="Version"/>,
    ///         then it is equal if the year and version-revision are equal.
    ///         Otherwise, it is not considered equal.
    ///     </para>
    ///
    ///     <para>
    ///         If the specified <see cref="object"/> is a <see cref="DateOnly"/>,
    ///         then it is equal if the year is equal to the year of the <see cref="DateOnly"/>
    ///         and the date is set to January 1st.
    ///     </para>
    /// 
    ///     <para>
    ///         If the specified <see cref="object"/> is a <see cref="DateTime"/>,
    ///         then it is equal if the year is equal to the year of the <see cref="DateTime"/>
    ///         and the date is set to January 1st at 00:00:00.000.
    ///     </para>
    ///
    ///     <para>
    ///         If the specified <see cref="object"/> is a byte array,
    ///         then it is equal if the Version read from the byte using
    ///         a call to <see cref="ReadBytes(byte[])"/> is equal to this <see cref="Version"/>
    ///         using a call to <see cref="Equals(Version)"/>.
    ///         If the byte array is a malformed version, then it is not equal.
    ///     </para>
    ///
    ///     <para>
    ///         In all other cases, it is not considered equal.
    ///         This includes if the <see cref="object"/> is <see langword="null"/>.
    ///     </para>
    /// </summary>
    /// <param name="obj">
    ///     An object to check for equality with this <see cref="Version"/>.
    ///     Rules for equality are defined in the summary.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the specified <see cref="object"/> is equal to the current <see cref="Version"/>;
    ///     otherwise, <see langword="false"/>.
    ///
    ///     <para>
    ///         For details on equality rules, see the summary.
    ///     </para>
    /// </returns>
    public override bool Equals(object? obj)
    {
        try
        {
            return obj switch
            {
                Version gifVersion => Year == gifVersion.Year &&
                                      Letter == gifVersion.Letter,
                DateOnly dateOnly => Year == dateOnly && Letter == 'a' &&
                                     dateOnly is { Month: 1, Day: 1 },
                DateTime dateTime => Year.Year == dateTime.Year &&
                                     Letter == 'a' &&
                                     dateTime is
                                     {
                                         Month: 1, Day: 1, Hour: 0, Minute: 0,
                                         Second: 0, Millisecond: 0
                                     },
                byte[] data => Equals(ReadBytes(data)),
                _ => false
            };
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    /// <summary>
    ///     Checks if the specified <see cref="Version"/> is equal to the current <see cref="Version"/>.
    ///
    ///     <para>
    ///         Two <see cref="Version"/> objects are equal if their year and version-revision are equal.
    ///     </para>
    /// </summary>
    /// <param name="other">
    ///     The <see cref="Version"/> to check for equality with this <see cref="Version"/>.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the specified <see cref="Version"/> is equal to the current <see cref="Version"/>;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    ///     This is a helper method for the <see cref="Equals(object)"/> method.
    /// </remarks>
    private bool Equals(Version other)
    {
        return _year.Equals(other._year) && _letter == other._letter;
    }

    /// <summary>
    ///     Equality operator between two <see cref="Version"/> objects.
    ///
    ///     <para>
    ///         Two <see cref="Version"/> objects are equal if their year and version-revision are equal.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the two <see cref="Version"/> objects are equal;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(Version left, Version right)
    {
        return Equals(left, right);
    }

    /// <summary>
    ///     Inequality operator between two <see cref="Version"/> objects.
    ///
    ///     <para>
    ///         Two <see cref="Version"/> objects are not equal if their year or version-revision are not equal.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the two <see cref="Version"/> objects are not equal;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(Version left, Version right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    ///     Equality operator between a <see cref="Version"/> object and a <see cref="DateOnly"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is equal to a <see cref="DateOnly"/> object if the year is equal
    ///         to the year of the <see cref="DateOnly"/> object and the date is set to January 1st.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the equality operator (a <see cref="DateOnly"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is equal to the <see cref="DateOnly"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(Version left, DateOnly right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Inequality operator between a <see cref="Version"/> object and a <see cref="DateOnly"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is not equal to a <see cref="DateOnly"/> object if the year is not equal
    ///         to the year of the <see cref="DateOnly"/> object or the date is not set to January 1st.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the inequality operator (a <see cref="DateOnly"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is not equal to the <see cref="DateOnly"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(Version left, DateOnly right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    ///     Equality operator between a <see cref="Version"/> object and a <see cref="DateOnly"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is equal to a <see cref="DateOnly"/> object if the year is equal
    ///         to the year of the <see cref="DateOnly"/> object and the date is set to January 1st.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the equality operator (a <see cref="DateOnly"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is equal to the <see cref="DateOnly"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(DateOnly left, Version right)
    {
        return right.Equals(left);
    }

    /// <summary>
    ///     Inequality operator between a <see cref="Version"/> object and a <see cref="DateOnly"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is not equal to a <see cref="DateOnly"/> object if the year is not equal
    ///         to the year of the <see cref="DateOnly"/> object or the date is not set to January 1st.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the inequality operator (a <see cref="DateOnly"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is not equal to the <see cref="DateOnly"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(DateOnly left, Version right)
    {
        return !right.Equals(left);
    }

    /// <summary>
    ///     Equality operator between a <see cref="Version"/> object and a <see cref="DateTime"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is equal to a <see cref="DateTime"/> object if the year is equal
    ///         to the year of the <see cref="DateTime"/> object and the date is set to January 1st at 00:00:00.000.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the equality operator (a <see cref="DateTime"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is equal to the <see cref="DateTime"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(Version left, DateTime right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Inequality operator between a <see cref="Version"/> object and a <see cref="DateTime"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is not equal to a <see cref="DateTime"/> object if the year is not equal
    ///         to the year of the <see cref="DateTime"/> object or the date is not set to January 1st at 00:00:00.000.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the inequality operator (a <see cref="DateTime"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is not equal to the <see cref="DateTime"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(Version left, DateTime right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    ///     Equality operator between a <see cref="Version"/> object and a <see cref="DateTime"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is equal to a <see cref="DateTime"/> object if the year is equal
    ///         to the year of the <see cref="DateTime"/> object and the date is set to January 1st at 00:00:00.000.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the equality operator (a <see cref="DateTime"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the equality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is equal to the <see cref="DateTime"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(DateTime left, Version right)
    {
        return right.Equals(left);
    }

    /// <summary>
    ///     Inequality operator between a <see cref="Version"/> object and a <see cref="DateTime"/> object.
    ///
    ///     <para>
    ///         A <see cref="Version"/> object is not equal to a <see cref="DateTime"/> object if the year is not equal
    ///         to the year of the <see cref="DateTime"/> object or the date is not set to January 1st at 00:00:00.000.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The left operand of the inequality operator (a <see cref="DateTime"/> object).
    /// </param>
    /// <param name="right">
    ///     The right operand of the inequality operator (a <see cref="Version"/> object).
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="Version"/> object is not equal to the <see cref="DateTime"/> object;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(DateTime left, Version right)
    {
        return !right.Equals(left);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_year, _letter);
    }

    /// <summary>
    ///     Converts a <see cref="Version"/> object to a <see cref="DateOnly"/> object.
    /// </summary>
    /// <param name="version">
    ///     The <see cref="Version"/> object to convert to a <see cref="DateOnly"/> object.
    /// </param>
    /// <returns>
    ///     The <see cref="DateOnly"/> object that represents the year of the <see cref="Version"/>.
    /// </returns>
    /// <remarks>
    ///     The <see cref="DateOnly"/> is always set to January 1st of the year of the <see cref="Version"/>.
    /// </remarks>
    public static explicit operator DateOnly(Version version)
    {
        return version.Year;
    }

    /// <summary>
    ///     Converts a <see cref="Version"/> object to a <see cref="DateTime"/> object.
    /// </summary>
    /// <param name="version">
    ///     The <see cref="Version"/> object to convert to a <see cref="DateTime"/> object.
    /// </param>
    /// <returns>
    ///     The <see cref="DateTime"/> object that represents the year of the <see cref="Version"/>.
    /// </returns>
    /// <remarks>
    ///     The <see cref="DateTime"/> is always set to January 1st 00:00:00.000 of the year of the <see cref="Version"/>.
    /// </remarks>
    public static explicit operator DateTime(Version version)
    {
        return new DateTime(version.Year.Year, 1, 1);
    }

    /// <summary>
    ///     Helper method to convert the year to a string.
    ///
    ///     <para>
    ///         The string is the last two digits of the year.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The last two digits of the year as a string.
    /// </returns>
    /// <exception cref="UnreachableException">
    ///     Thrown if the year is not 4 digits long.
    ///
    ///     <para>
    ///         As this is an unreachable exception, it should never be thrown.
    ///         If it is thrown, it is a bug in the code or an oversight due
    ///         to changing circumstances that were not accounted for in the future.
    ///     </para>
    /// </exception>
    private string YearToString()
    {
        string yearString = Year.Year.ToString();
        if (yearString.Length != 4)
        {
            throw new UnreachableException("Year must be 4 digits long.");
        }

        char secondToLastDigit = yearString[2];
        char lastDigit = yearString[3];
        return $"{secondToLastDigit}{lastDigit}";
    }

    /// <summary>
    ///     Get the string representation of the <see cref="Version"/> object.
    ///
    ///     <para>
    ///         The string is "Gif Version " followed by the two last digits of the year and the version-revision letter.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The <see cref="Version"/> object as a string.
    /// </returns>
    public override string ToString()
    {
        return $"Gif Version {YearToString()}{Letter}";
    }
}