using System.Collections;
using System.Diagnostics;
using System.Text;
using JetBrains.Annotations;

namespace GifHarness.Components.Colors;

/// <summary>
///     <para>
///         Represents a GIF color table.
///         A color table is a list of colors that can be used in a GIF image.
///         Keep in mind that the number of colors in a color table must be
///         2, 4, 8, 16, 32, 64, 128 or 256.
///     </para>
///
///     <para>
///         Unlike the <see cref="ColorTableBuilder"/> class, this class
///         is immutable in regard to the number of colors in the color table
///         and will always have a valid fixed number of colors.
///     </para> 
/// </summary>
public class ColorTable : IByteSerializable<ColorTable>, IReadOnlyList<Color>
{
    /// <summary>
    ///     The colors in the color table.
    ///     The number of colors will always be 2, 4, 8, 16, 32, 64, 128 or 256.
    /// </summary>
    private readonly Color[] _colors;

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="ColorTable"/> class.
    ///         The number of colors in the color table must be 2, 4, 8, 16, 32, 64, 128 or 256.
    ///     </para>
    ///
    ///     <para>
    ///         This constructor is private and is only used by the <see cref="ReadBytes"/> method.
    ///         The check for the number of colors is done in the <see cref="ReadBytes"/> method
    ///         and not in this constructor.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     The colors in the color table.
    /// </param>
    /// <remarks>
    ///     This constructor exists to allow the <see cref="ReadBytes"/> method
    ///     to create a <see cref="ColorTable"/> object without checking the number of colors
    ///     nor allocating a new array for the colors.
    /// </remarks>
    private ColorTable(Color[] colors)
    {
        _colors = colors;
        SetNumberOfColorsInLogicalScreenDescriptor();
    }

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="ColorTable"/> class
    ///         from any <see cref="IEnumerable{T}"/> of <see cref="Color"/> objects.
    ///     </para>
    ///
    ///     <para>
    ///         The number of colors in the color table must be 2, 4, 8, 16, 32, 64, 128 or 256.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     The colors in the color table.
    /// </param>
    /// <exception cref="ArgumentException">
    ///     Thrown if the number of colors is not 2, 4, 8, 16, 32, 64, 128 or 256.
    /// </exception>
    /// <exception cref="UnreachableException">
    ///     <para>
    ///         Thrown if the enumerator length is not equal to the number of colors
    ///         counted by the enumerator.
    ///     </para>
    ///
    ///     <para>
    ///         This is an active check to ensure that the enumerator is not modified
    ///         after counting the number of colors and that the code is correct.
    ///     </para>
    ///
    ///     <para>
    ///         This exception should never be thrown.
    ///     </para>
    /// </exception>
    public ColorTable(IEnumerable<Color> colors)
        : this(colors.GetEnumerator())
    { }

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="ColorTable"/> class
    ///         from any <see cref="IEnumerator{T}"/> of <see cref="Color"/> objects.
    ///     </para>
    ///
    ///     <para>
    ///         the number of colors in the color table must be 2, 4, 8, 16, 32, 64, 128 or 256.
    ///         this constructor will dispose of the enumerator
    ///         if <paramref name="doNotDisposeEnumerator"/>
    ///         is set to <see langword="false"/> (the default).
    ///     </para>
    ///
    ///     <para>
    ///         This constructor is private and used by the other constructors.
    ///     </para>
    /// </summary>
    /// <param name="colorEnumerator">
    ///     <para>
    ///         The enumerator of colors in the color table.
    ///     </para>
    ///
    ///     <para>
    ///         The number of colors in the color table must be 2, 4, 8, 16, 32, 64, 128 or 256.
    ///     </para>
    /// </param>
    /// <param name="doNotDisposeEnumerator">
    ///     <para>
    ///         Whether to dispose of the enumerator or not.
    ///     </para>
    ///
    ///     <para>
    ///         If set to <see langword="true"/>, the enumerator will not be disposed.
    ///     </para>
    ///
    ///     <para>
    ///         If set to <see langword="false"/>, the enumerator will be disposed.
    ///     </para>
    ///
    ///     <para>
    ///         The default value is <see langword="false"/> (the enumerator will be disposed).
    ///     </para>
    /// </param>
    /// <exception cref="ArgumentException">
    ///     Thrown if the number of colors is not 2, 4, 8, 16, 32, 64, 128 or 256.
    /// </exception>
    /// <exception cref="UnreachableException">
    ///     <para>
    ///         Thrown if the enumerator length is not equal to the number of colors
    ///         counted by the enumerator.
    ///     </para>
    ///
    ///     <para>
    ///         This is an active check to ensure that the enumerator is not modified
    ///         after counting the number of colors and that the code is correct.
    ///     </para>
    ///
    ///     <para>
    ///         This exception should never be thrown.
    ///     </para>
    /// </exception>
    private ColorTable(IEnumerator<Color> colorEnumerator,
        bool doNotDisposeEnumerator = false)
    {
        colorEnumerator.Reset();
        int enumeratorLength = EnumeratorLength(colorEnumerator);
        if (!IsValidNumberOfColors(enumeratorLength))
        {
            ArgumentException exception = new(
                "The number of colors for a color table must be\n" +
                $"2, 4, 8, 16, 32, 64, 128 or 256 but was {enumeratorLength}",
                nameof(colorEnumerator));
            if (!doNotDisposeEnumerator)
            {
                colorEnumerator.Dispose();
            }

            throw exception;
        }

        _colors = new Color[enumeratorLength];

        colorEnumerator.Reset();
        int index = 0;
        while (colorEnumerator.MoveNext())
        {
            _colors[index] = colorEnumerator.Current;
            index += 1;
        }

        if (!doNotDisposeEnumerator)
        {
            colorEnumerator.Dispose();
        }

        if (index != enumeratorLength)
        {
            throw new UnreachableException(
                "index should be equal to enumerator length but isn't:\n" +
                "index != enumeratorLength\n" +
                $"{index} != {enumeratorLength}");
        }

        SetNumberOfColorsInLogicalScreenDescriptor();
    }

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="ColorTable"/> class
    ///         from a <see cref="ColorTableBuilder"/> object.
    ///     </para>
    ///
    ///     <para>
    ///         The number of colors in the color table must be 2, 4, 8, 16, 32, 64, 128 or 256.
    ///     </para>
    /// </summary>
    /// <param name="colorTableBuilder">
    ///     The color table builder to create the color table from.
    /// </param>
    /// <exception cref="ArgumentException">
    ///     Thrown if the number of colors is not 2, 4, 8, 16, 32, 64, 128 or 256.
    /// </exception>
    /// <exception cref="UnreachableException">
    ///     <para>
    ///         Thrown if the enumerator length is not equal to the number of colors
    ///         counted by the enumerator.
    ///     </para>
    ///
    ///     <para>
    ///         This is an active check to ensure that the enumerator is not modified
    ///         after counting the number of colors and that the code is correct.
    ///     </para>
    ///
    ///     <para>
    ///         This exception should never be thrown.
    ///     </para>
    /// </exception>
    public ColorTable(ColorTableBuilder colorTableBuilder)
        : this(colorTableBuilder.GetEnumerator())
    { }

    /// <summary>
    ///     <para>
    ///         Initializes a new instance of the <see cref="ColorTable"/> class
    ///         from another <see cref="ColorTable"/> object.
    ///     </para>
    ///
    ///     <para>
    ///         This acts as a copy constructor.
    ///     </para>
    ///
    ///     <para>
    ///         The constructor will create a deep copy of the colors in the color table
    ///         if <paramref name="deepCopy"/> is set to <see langword="true"/> (the default).
    ///     </para>
    ///
    ///     <para>
    ///         If <paramref name="deepCopy"/> is set to <see langword="false"/>,
    ///         the underlying array of colors will be shared between the two objects.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The color table to create a copy of.
    /// </param>
    /// <param name="deepCopy">
    ///     <para>
    ///         Whether to create a deep copy of the colors in the color table or not.
    ///     </para>
    ///
    ///     <para>
    ///         If set to <see langword="true"/>, a deep copy will be created.
    ///     </para>
    /// 
    ///     <para>
    ///         If set to <see langword="false"/>, the underlying array of colors will be shared.
    ///     </para>
    /// </param>
    public ColorTable(ColorTable colorTable, bool deepCopy = true)
    {
        NumberOfColorsInLogicalScreenDescriptor =
            colorTable.NumberOfColorsInLogicalScreenDescriptor;

        if (!deepCopy)
        {
            _colors = colorTable._colors;
            return;
        }

        _colors = new Color[colorTable.Count];

        for (int index = 0; index < colorTable.Count; index++)
            _colors[index] = new Color(colorTable[index]);
    }

    /// <summary>
    ///     <para>
    ///         The GIF format employs color table count information by
    ///         way of a value stored in the Logical Screen Descriptor.
    ///     </para>
    ///
    ///     <para>
    ///         If the value is 0, the color table has 2 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 1, the color table has 4 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 2, the color table has 8 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 3, the color table has 16 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 4, the color table has 32 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 5, the color table has 64 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 6, the color table has 128 colors.
    ///     </para>
    /// 
    ///     <para>
    ///         If the value is 7, the color table has 256 colors.
    ///     </para>
    ///
    ///     <para>
    ///         This property is calculated from the number of colors
    ///         in the color table at the time of construction.
    ///     </para>
    /// </summary>
    public int NumberOfColorsInLogicalScreenDescriptor { get; private set; }

    /// <summary>
    ///     <para>
    ///         Helper method for the constructor to set the number of colors encoded in the logical screen descriptor
    ///         to the current amount depending on the number of colors in the color table.
    ///     </para>
    ///
    ///     <para>
    ///         That is:
    ///         0 encoded if 2 colors are present.
    ///         1 encoded if 4 colors are present.
    ///         2 encoded if 8 colors are present.
    ///         3 encoded if 16 colors are present.
    ///         4 encoded if 32 colors are present.
    ///         5 encoded if 64 colors are present.
    ///         6 encoded if 128 colors are present.
    ///         7 encoded if 256 colors are present.
    ///     </para>
    ///
    ///     <para>
    ///         Any other amount of colors being present should never happen due to constructor checks.
    ///         The responsibility of making sure that number of colors is valid falls on the caller.
    ///         If the number of colors is invalid, throws an <see cref="UnreachableException"/>.
    ///     </para>
    /// </summary>
    /// <exception cref="UnreachableException">
    ///     <para>
    ///         Thrown if the number of colors in the color table is invalid (it is not either 1, 2, 4, 8, 16, 32, 64, 128 or 256).
    ///     </para>
    ///
    ///     <para>
    ///         This is an active check to ensure that the number of colors in the color table is valid.
    ///     </para>
    ///
    ///     <para>
    ///         This exception should never be thrown.
    ///     </para>
    /// </exception>
    private void SetNumberOfColorsInLogicalScreenDescriptor()
    {
        NumberOfColorsInLogicalScreenDescriptor = _colors.Length switch
        {
            2 => 0,
            4 => 1,
            8 => 2,
            16 => 3,
            32 => 4,
            64 => 5,
            128 => 6,
            256 => 7,
            _ => throw new UnreachableException(
                $"_colors.Length: {_colors.Length}")
        };
    }

    public static ColorTable ReadBytes(byte[] data)
    {
        ValidateSerializedBytes(data);

        int numberOfColors = data.Length / 3;
        Color[] colors = new Color[numberOfColors];

        for (int index = 0; index < numberOfColors; index += 1)
        {
            byte redComponent = data[index * 3];
            byte greenComponent = data[index * 3 + 1];
            byte blueComponent = data[index * 3 + 2];

            colors[index] =
                new Color(redComponent, greenComponent, blueComponent);
        }

        return new ColorTable(colors);
    }

    /// <summary>
    ///     <para>
    ///         Helper method to validate serialized bytes representing a color table.
    ///         If valid, the method does nothing.
    ///         If invalid the method throws an exception.
    ///     </para>
    ///
    ///     <para>
    ///         For the serialized byte data representing the color table to be valid,
    ///         these requirements need to be met:
    ///     </para>
    ///
    ///     <para>
    ///         The number of bytes must be a multiple of 3
    ///     </para>
    ///
    ///     <para>
    ///         The number of bytes must be between 6 and 768 (both included).
    ///         (So between 2 and 256 colors (both included)).
    ///     </para>
    ///
    ///     <para>
    ///         The number of bytes must be a power of two.
    ///     </para>
    ///
    ///     <para>
    ///         In other words 2, 4, 8, 16, 32, 64, 128 and 256 are the only accepted amounts of color.
    ///         (That is 6, 12, 24, 48, 96, 192, 384 or 768 are the only accepted amounts of bytes).
    ///     </para>
    /// </summary>
    /// <param name="data">
    ///     The serialized bytes to validate.
    /// </param>
    /// <exception cref="ArgumentException">
    ///     The number of bytes is not a multiple of three.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     The number of bytes is less than 6 or greater than 768.
    ///     (So the number of colors is less than 2 or greater than 256.)
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     The number of colors (a color takes up 3 bytes) is not a power of two.
    /// </exception>
    private static void ValidateSerializedBytes(byte[] data)
    {
        if (data.Length % 3 != 0)
        {
            throw new ArgumentException(
                "Color table data must have a number of bytes " +
                "that is a multiple of 3.",
                nameof(data)
            );
        }

        int numberOfColors = data.Length / 3;
        if (numberOfColors is < 2 or > 256)
        {
            throw new ArgumentException(
                "Color table data must have a number of colors " +
                "between 2 and 256 (both included) (so between 6 and 768" +
                " bytes in length (also both included)).\n" +
                $"(found {numberOfColors} colors ({data.Length} bytes)).",
                nameof(data));
        }

        bool isPowerOfTwo = (numberOfColors & (numberOfColors - 1)) == 0;
        if (!isPowerOfTwo)
        {
            throw new ArgumentException(
                "Color table data must have a number of colors " +
                "which is a power of 2 \n" +
                "(in other words 2, 4, 8, 16, 32, 64, 128 and 256 " +
                "are acceptable values).\n" +
                "For byte counts that is equivalent to 6, 12, 24, 48, 96, " +
                "192, 384 or 768 as acceptable values respectively.\n" +
                $"Number of colors provided: {numberOfColors} ({data.Length} bytes).");
        }
    }

    public static byte[] WriteBytes(ColorTable obj)
    {
        byte[] bytes = new byte[obj.Count * 3];

        for (int index = 0; index < obj.Count; index++)
        {
            Color color = obj[index];

            bytes[index * 3] = color.RedComponent;
            bytes[index * 3 + 1] = color.GreenComponent;
            bytes[index * 3 + 2] = color.BlueComponent;
        }

        return bytes;
    }

    /// <summary>
    ///     <para>
    ///         Checks if an amount of colors is a valid amount of colors for a color table.
    ///     </para>
    ///
    ///     <para>
    ///         The color amounts which are considered valid are 2, 4, 8, 16, 32, 64, 128 and 256.
    ///     </para>
    ///
    ///     <para>
    ///         Returns if a color amount for a color table is valid.
    ///     </para>
    /// </summary>
    /// <param name="count">
    ///     The amount of colors for a color table to check.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the color amount is valid.
    ///     <see langword="false"/> if the color amount is invalid.
    /// </returns>
    public static bool IsValidNumberOfColors(int count)
    {
        const int maxColors = 256;
        const int minColors = 2;

        if (count is < minColors or > maxColors)
        {
            return false;
        }

        bool isPowerOfTwo = (count & (count - 1)) == 0;
        return isPowerOfTwo;
    }

    /// <summary>
    ///     <para>
    ///         Checks if an amount of colors in <paramref name="colorTableBuilder"/> is a valid amount of colors for a color table.
    ///     </para>
    ///
    ///     <para>
    ///         The color amounts which are considered valid are 2, 4, 8, 16, 32, 64, 128 and 256.
    ///     </para>
    ///
    ///     <para>
    ///         Returns if a color amount for a color table is valid.
    ///     </para>
    /// </summary>
    /// <param name="colorTableBuilder">
    ///     The color table builder to check the amount of colors for.     
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the color amount is valid.
    ///     <see langword="false"/> if the color amount is invalid.
    /// </returns>
    public static bool IsValidNumberOfColors(
        ColorTableBuilder colorTableBuilder)
    {
        return IsValidNumberOfColors(colorTableBuilder.Count);
    }

    /// <summary>
    ///     <para>
    ///         Checks if an amount of colors enumerated in <paramref name="colors"/> is a valid amount of colors for a color table.
    ///     </para>
    ///
    ///     <para>
    ///         The color amounts which are considered valid are 2, 4, 8, 16, 32, 64, 128 and 256.
    ///     </para>
    ///
    ///     <para>
    ///         Returns if a color amount for a color table is valid.
    ///     </para>
    ///
    ///     <para>
    ///         WARNING: This code enumerates the code to count the colors.
    ///         Be careful if your object doesn't support multiple enumerations.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     The color <see cref="IEnumerable{Color}"/> to check the amount of colors for.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the color amount is valid.
    ///     <see langword="false"/> if the color amount is invalid.
    /// </returns>
    public static bool IsValidNumberOfColors(
        IEnumerable<Color> colors)
    {
        IEnumerator<Color> enumerator = colors.GetEnumerator();
        bool result = IsValidNumberOfColors(enumerator);

        enumerator.Dispose();
        return result;
    }

    /// <summary>
    ///     <para>
    ///         Checks if an amount of colors enumerated in <paramref name="colors"/> is a valid amount of colors for a color table.
    ///     </para>
    ///
    ///     <para>
    ///         The color amounts which are considered valid are 2, 4, 8, 16, 32, 64, 128 and 256.
    ///     </para>
    ///
    ///     <para>
    ///         Returns if a color amount for a color table is valid.
    ///     </para>
    ///
    ///     <para>
    ///         WARNING: This code enumerates the code to count the colors.
    ///         Be careful if your object doesn't support multiple enumerations.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     The color <see cref="IEnumerator{Color}"/> to check the amount of colors for.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the color amount is valid.
    ///     <see langword="false"/> if the color amount is invalid.
    /// </returns>
    private static bool IsValidNumberOfColors(
        IEnumerator colors)
    {
        int count = EnumeratorLength(colors);
        return IsValidNumberOfColors(count);
    }

    /// <summary>
    ///     <para>
    ///         Checks if an amount of colors passed as parameters is a valid amount of colors for a color table.
    ///     </para>
    ///
    ///     <para>
    ///         The color amounts which are considered valid are 2, 4, 8, 16, 32, 64, 128 and 256.
    ///     </para>
    ///
    ///     <para>
    ///         Returns if a color amount for a color table is valid.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     A variable amount of <see cref="Color"/> parameters to check the amount of colors for.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the color amount is valid.
    ///     <see langword="false"/> if the color amount is invalid.
    /// </returns>
    public static bool IsValidNumberOfColors(params Color[] colors)
    {
        return IsValidNumberOfColors(colors.Length);
    }


    /// <summary>
    ///     Helper method to count the number of colors left
    ///     (does not reset before counting) in the <see cref="IEnumerator"/>.
    ///
    ///     <para>
    ///         WARNING: This does enumerate through the enumerator.
    ///         The responsibility for making sure that multi enumeration is not a problem
    ///         falls on the caller.
    ///     </para>
    /// </summary>
    /// <param name="colors">
    ///     The colors to enumerate through
    /// </param>
    /// <returns></returns>
    private static int EnumeratorLength(IEnumerator colors)
    {
        int count = 0;
        while (colors.MoveNext())
        {
            count += 1;
        }

        colors.Reset();
        return count;
    }

    /// <summary>
    ///     Returns an enumerator that iterates through the <see cref="_colors"/>.
    ///
    ///     <para>
    ///         WARNING: The user of the function
    ///         must dispose of the enumerator by calling the Dispose method on the enumerator.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     An enumerator that can be used to iterate through the <see cref="_colors"/>.
    /// </returns>
    [MustDisposeResource]
    public IEnumerator<Color> GetEnumerator()
    {
        return ((IEnumerable<Color>)_colors).GetEnumerator();
    }

    /// <summary>
    ///     Returns an enumerator that iterates through a <see cref="_colors"/>.
    ///
    ///     <para>
    ///         WARNING: The user of the function
    ///         must dispose of the enumerator by calling the Dispose method on the enumerator.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     An <see cref="T:System.Collections.IEnumerator" /> object
    ///     that can be used to iterate through the <see cref="_colors"/>.
    /// </returns>
    [MustDisposeResource]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    ///     Gets the number of <see cref="Color"/>s in the <see cref="ColorTable"/>.
    /// </summary>
    /// <returns>
    ///     The number of <see cref="Color"/>s in the <see cref="ColorTable"/>.
    /// </returns>
    public int Count => _colors.Length;

    /// <summary>
    ///     Gets the <see cref="Color"/> at the specified <paramref name="index"/> in <see cref="ColorTable"/>.
    /// </summary>
    /// <param name="index">
    ///     The zero-based index of the <see cref="Color"/> to get.
    /// </param>
    /// <returns>
    ///     The <see cref="Color"/> at the specified index in the <see cref="ColorTable"/>.
    /// </returns>
    public Color this[int index] => _colors[index];

    /// <summary>
    ///     <para>
    ///         Checks if this <see cref="ColorTable"/> is equal to an <see langword="object"/>
    ///     </para>
    ///
    ///     <para>
    ///         An <see langword="object"/> is considered equal if:
    ///     </para>
    ///
    ///     <para>
    ///         it is a <see cref="ColorTable"/> and the number of colors
    ///         and the colors (their order matters) is the same.
    ///     </para>
    ///
    ///     <para>
    ///         it is a <see cref="ColorTableBuilder"/> and the number of colors
    ///         and the colors (their order matters) is the same.
    ///     </para>
    ///
    ///     <para>
    ///         it is an <see cref="IEnumerable{Color}"/> and the color sequence of
    ///         the enumerable matches the colors in the color table (order matters).
    ///         WARNING: This will enumerate through the <see cref="IEnumerable{Color}"/> object and
    ///         the responsibility for making sure code does not break due to multiple enumeration falls on the caller.
    ///     </para>
    ///
    ///     <para>
    ///         it is an <see cref="Array"/> of <see langword="byte"/>s
    ///         and the color table it represents is the same as this one (color table equality rules apply).
    ///         If the byte array is an invalid serialization of a <see cref="ColorTable"/>, then it is considered not the same as this.
    ///     </para>
    ///
    ///     <para>
    ///         If it is anything else, then it is considered not equal.
    ///     </para>
    /// </summary>
    /// <param name="obj">
    ///     The <see langword="object"/> to check equality against.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <paramref name="obj"/> is considered equal to this <see cref="ColorTable"/>.
    ///     <see langword="false"/> if the <paramref name="obj"/> is considered not equal to this <see cref="ColorTable"/>.
    /// </returns>
    public override bool Equals(object? obj)
    {
        switch (obj)
        {
            case ColorTable colorTable:
                return _colors.SequenceEqual(colorTable);
            case ColorTableBuilder colorTableBuilder:
                return _colors.SequenceEqual(colorTableBuilder);
            case IEnumerable<Color> colors:
                return _colors.SequenceEqual(colors);
        }

        if (obj is not byte[] data)
        {
            return false;
        }

        try
        {
            return data.Length % 3 == 0 && _colors.SequenceEqual(ReadBytes(data));
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    /// <summary>
    ///     Checks if this <see cref="ColorTable"/> is equal to a <see cref="ColorTable"/>.
    ///
    ///     <para>
    ///         Two <see cref="ColorTable"/>s are considered equal if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The <see cref="ColorTable"/> to check equality against.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if this <see cref="ColorTable"/> is equal to <paramref name="colorTable"/>
    ///     <see langword="false"/> if this <see cref="ColorTable"/> is not equal to <paramref name="colorTable"/>.
    /// </returns>
    public bool Equals(ColorTable colorTable)
    {
        return _colors.SequenceEqual(colorTable);
    }

    public override int GetHashCode()
    {
        return _colors.GetHashCode();
    }

    /// <summary>
    ///     Gets the <see langword="string"/> representing this <see cref="ColorTable"/>.
    ///
    ///     <para>
    ///         The format is as follows:
    ///         Color Table: [ColorA, ColorB, ColorC]
    ///     </para>
    ///
    ///     <para>
    ///         The format for each color is that of <see cref="Color.ToString"/> that is to say:
    ///
    ///         $"Color: (R: {RedComponent}, G: {GreenComponent}, B: {BlueComponent})"
    ///     </para>
    /// </summary>
    /// <returns>
    ///     The <see langword="string"/> representation of this <see cref="ColorTable"/>.
    /// </returns>
    public override string ToString()
    {
        StringBuilder builder = new();
        builder.Append("Color Table: [");
        for (int i = 0; i < _colors.Length; i++)
        {
            Color color = _colors[i];
            builder.Append(color);
            if (i < _colors.Length - 1)
            {
                builder.AppendLine(",");
            }
        }

        builder.Append(']');
        return builder.ToString();
    }

    /// <summary>
    ///     Create a <see cref="ColorTableBuilder"/> equivalent to this <see cref="ColorTable"/>.
    /// </summary>
    /// <returns>
    ///     An equivalent <see cref="ColorTableBuilder"/> to this <see cref="ColorTable"/>.
    /// </returns>
    public ColorTableBuilder ToBuilder()
    {
        return new ColorTableBuilder(this);
    }

    /// <summary>
    ///     Checks if two <see cref="ColorTable"/>s are equal.
    ///
    ///     <para>
    ///         Two <see cref="ColorTable"/>s are considered equal if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="leftColorTable">
    ///     The left <see cref="ColorTable"/> operand.
    /// </param>
    /// <param name="rightColorTable">
    ///     The right <see cref="ColorTable"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="leftColorTable"/> is equal to <paramref name="rightColorTable"/>
    ///     <see langword="false"/> if <paramref name="leftColorTable"/> is not equal to <paramref name="rightColorTable"/>.
    /// </returns>
    public static bool operator ==(ColorTable leftColorTable,
        ColorTable rightColorTable)
    {
        return leftColorTable.Count == rightColorTable.Count &&
               leftColorTable._colors.SequenceEqual(rightColorTable._colors);
    }

    /// <summary>
    ///     Checks if two <see cref="ColorTable"/>s are not equal.
    ///
    ///     <para>
    ///         Two <see cref="ColorTable"/>s are considered equal if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="leftColorTable">
    ///     The left <see cref="ColorTable"/> operand.
    /// </param>
    /// <param name="rightColorTable">
    ///     The right <see cref="ColorTable"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="leftColorTable"/> is not equal to <paramref name="rightColorTable"/>
    ///     <see langword="false"/> if <paramref name="leftColorTable"/> is equal to <paramref name="rightColorTable"/>.
    /// </returns>
    public static bool operator !=(ColorTable leftColorTable,
        ColorTable rightColorTable)
    {
        return !(leftColorTable == rightColorTable);
    }

    /// <summary>
    ///     Checks if a <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are equal.
    ///
    ///     <para>
    ///         A <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are considered equal
    ///         if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The left <see cref="ColorTable"/> operand.
    /// </param>
    /// <param name="colorTableBuilder">
    ///     The right <see cref="ColorTableBuilder"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="colorTable"/> is equal to <paramref name="colorTableBuilder"/>
    ///     <see langword="false"/> if <paramref name="colorTable"/> is not equal to <paramref name="colorTableBuilder"/>.
    /// </returns>
    public static bool operator ==(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return Equality(colorTable, colorTableBuilder);
    }

    /// <summary>
    ///     Checks if a <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are equal.
    ///
    ///     <para>
    ///         A <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are considered equal
    ///         if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The left <see cref="ColorTable"/> operand.
    /// </param>
    /// <param name="colorTableBuilder">
    ///     The right <see cref="ColorTableBuilder"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="colorTable"/> is not equal to <paramref name="colorTableBuilder"/>
    ///     <see langword="false"/> if <paramref name="colorTable"/> is equal to <paramref name="colorTableBuilder"/>.
    /// </returns>
    public static bool operator !=(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return !Equality(colorTable, colorTableBuilder);
    }

    /// <summary>
    ///     Checks if a <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are equal.
    ///
    ///     <para>
    ///         A <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are considered equal
    ///         if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The left <see cref="ColorTableBuilder"/> operand.
    /// </param>
    /// <param name="colorTableBuilder">
    ///     The right <see cref="ColorTable"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="colorTable"/> is equal to <paramref name="colorTableBuilder"/>
    ///     <see langword="false"/> if <paramref name="colorTable"/> is not equal to <paramref name="colorTableBuilder"/>.
    /// </returns>
    public static bool operator ==(ColorTableBuilder colorTableBuilder,
        ColorTable colorTable)
    {
        return Equality(colorTable, colorTableBuilder);
    }

    /// <summary>
    ///     Checks if a <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are equal.
    ///
    ///     <para>
    ///         A <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are considered equal
    ///         if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The left <see cref="ColorTableBuilder"/> operand.
    /// </param>
    /// <param name="colorTableBuilder">
    ///     The right <see cref="ColorTable"/> operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="colorTable"/> is not equal to <paramref name="colorTableBuilder"/>
    ///     <see langword="false"/> if <paramref name="colorTable"/> is equal to <paramref name="colorTableBuilder"/>.
    /// </returns>
    public static bool operator !=(ColorTableBuilder colorTableBuilder,
        ColorTable colorTable)
    {
        return !Equality(colorTable, colorTableBuilder);
    }

    /// <summary>
    ///     Helper method which checks if a <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are equal.
    ///
    ///     <para>
    ///         A <see cref="ColorTable"/> and a <see cref="ColorTableBuilder"/> are considered equal
    ///         if they have the same number of <see cref="Color"/>s
    ///         in the same order.
    ///     </para>
    /// </summary>
    /// <param name="colorTable">
    ///     The <see cref="ColorTable"/>
    /// </param>
    /// <param name="colorTableBuilder">
    ///     The <see cref="ColorTableBuilder"/>
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if <paramref name="colorTable"/> is equal to <paramref name="colorTableBuilder"/>
    ///     <see langword="false"/> if <paramref name="colorTable"/> is not equal to <paramref name="colorTableBuilder"/>.
    /// </returns>
    private static bool Equality(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return colorTable.Count == colorTableBuilder.Count &&
               colorTable._colors.SequenceEqual(colorTableBuilder);
    }
}