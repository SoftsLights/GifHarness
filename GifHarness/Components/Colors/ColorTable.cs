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
    /// 
    /// </summary>
    /// <exception cref="UnreachableException"></exception>
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

    public static bool IsValidNumberOfColors(int count)
    {
        const int maxColors = 256;
        const int minColors = 2;

        if (count is < minColors or > maxColors)
        {
            return false;
        }

        return (count & (count - 1)) == 0;
    }

    public static bool IsValidNumberOfColors(
        ColorTableBuilder colorTableBuilder)
    {
        return IsValidNumberOfColors(colorTableBuilder.Count);
    }

    public static bool IsValidNumberOfColors(
        IEnumerable<Color> colors)
    {
        IEnumerator<Color> enumerator = colors.GetEnumerator();
        bool result = IsValidNumberOfColors(enumerator);

        enumerator.Dispose();
        return result;
    }

    private static bool IsValidNumberOfColors(
        IEnumerator colors)
    {
        int count = EnumeratorLength(colors);
        return IsValidNumberOfColors(count);
    }

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

    public static bool IsValidNumberOfColors(params Color[] colors)
    {
        return IsValidNumberOfColors(colors.Length);
    }

    [MustDisposeResource]
    public IEnumerator<Color> GetEnumerator()
    {
        return ((IEnumerable<Color>)_colors).GetEnumerator();
    }

    [MustDisposeResource]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count => _colors.Length;

    public Color this[int index] => _colors[index];

    public override bool Equals(object? obj)
    {
        return obj switch
        {
            ColorTable colorTable => _colors.SequenceEqual(colorTable),
            ColorTableBuilder colorTable => _colors.SequenceEqual(colorTable),
            IEnumerable<Color> colors => _colors.SequenceEqual(colors),
            byte[] data => data.Length % 3 == 0 &&
                           _colors.SequenceEqual(ReadBytes(data)),
            _ => false
        };
    }

    public bool Equals(ColorTable colorTable)
    {
        return _colors.SequenceEqual(colorTable);
    }

    public override int GetHashCode()
    {
        return _colors.GetHashCode();
    }

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

    public ColorTableBuilder ToBuilder()
    {
        return new ColorTableBuilder(this);
    }

    public static bool operator ==(ColorTable leftColorTable,
        ColorTable rightColorTable)
    {
        return leftColorTable.Count == rightColorTable.Count &&
               leftColorTable._colors.SequenceEqual(rightColorTable._colors);
    }

    public static bool operator !=(ColorTable leftColorTable,
        ColorTable rightColorTable)
    {
        return !(leftColorTable == rightColorTable);
    }

    public static bool operator ==(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return Equality(colorTable, colorTableBuilder);
    }

    public static bool operator !=(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return !Equality(colorTable, colorTableBuilder);
    }

    public static bool operator ==(ColorTableBuilder colorTableBuilder,
        ColorTable colorTable)
    {
        return Equality(colorTable, colorTableBuilder);
    }

    public static bool operator !=(ColorTableBuilder colorTableBuilder,
        ColorTable colorTable)
    {
        return !Equality(colorTable, colorTableBuilder);
    }

    private static bool Equality(ColorTable colorTable,
        ColorTableBuilder colorTableBuilder)
    {
        return colorTable.Count == colorTableBuilder.Count &&
               colorTable._colors.SequenceEqual(colorTableBuilder);
    }
}