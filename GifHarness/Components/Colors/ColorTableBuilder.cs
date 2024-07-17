using System.Collections;
using System.Text;

// ReSharper disable SuspiciousTypeConversion.Global

namespace GifHarness.Components.Colors;

/// <summary>
///     A table of colors builder that can be serialized to and from bytes.
///     The table can have up to 256 colors.
///     The table is a list of colors.
///     If the table contains a valid number of colors, it can be converted to a
///     ColorTable object.
/// </summary>
public class ColorTableBuilder : IByteSerializable<ColorTableBuilder>,
    IList<Color>
{
    private List<Color> Colors { get; }

    public const int MaxColors = 1 << (7 + 1);

    private ColorTableBuilder(List<Color> colors)
    {
        Colors = colors;
    }

    public ColorTableBuilder(IEnumerable<Color> colors)
    {
        Colors = colors.ToList();
        if (Colors.Count > MaxColors)
        {
            throw new ArgumentOutOfRangeException(nameof(colors), colors,
                $"Color Table cannot have more than {MaxColors} colors.");
        }
    }

    public ColorTableBuilder(params Color[] colors)
    {
        Colors = colors.ToList();
        if (Colors.Count > MaxColors)
        {
            throw new ArgumentOutOfRangeException(nameof(colors), colors,
                $"Color Table cannot have more than {MaxColors} colors.");
        }
    }

    public static ColorTableBuilder ReadBytes(byte[] data)
    {
        int bytes = data.Length;
        if (bytes % 3 != 0)
        {
            throw new ArgumentException(
                "Color Table data must have a length that is a multiple of 3.",
                nameof(data)
            );
        }

        List<Color> colors = [];
        for (int i = 0; i < bytes; i += 3)
            colors.Add(new Color(data[i], data[i + 1], data[i + 2]));

        return new ColorTableBuilder(colors);
    }

    public ColorTableBuilder(ColorTableBuilder colorTableBuilder)
    {
        Colors = new List<Color>(colorTableBuilder.Colors);
    }

    public ColorTableBuilder(ColorTable colorTable)
    {
        Colors = new List<Color>(colorTable);
    }

    public static byte[] WriteBytes(ColorTableBuilder obj)
    {
        byte[] data = new byte[obj.Bytes];
        int i = 0;
        foreach (Color color in obj)
        {
            data[i++] = color.RedComponent;
            data[i++] = color.GreenComponent;
            data[i++] = color.BlueComponent;
        }

        return data;
    }

    public IEnumerator<Color> GetEnumerator()
    {
        return Colors.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Color item)
    {
        if (Colors.Count >= MaxColors)
        {
            throw new ArgumentOutOfRangeException(nameof(item), item,
                $"Color Table cannot have more than {MaxColors} colors.");
        }

        Colors.Add(item);
    }

    public void Clear()
    {
        Colors.Clear();
    }

    public bool Contains(Color item)
    {
        return Colors.Contains(item);
    }

    public void CopyTo(Color[] array, int arrayIndex)
    {
        Colors.CopyTo(array, arrayIndex);
    }

    public bool Remove(Color item)
    {
        return Colors.Remove(item);
    }

    public int Count => Colors.Count;

    public bool IsReadOnly => false;

    public int Bytes => Colors.Count * 3;

    public int IndexOf(Color item)
    {
        return Colors.IndexOf(item);
    }

    public void Insert(int index, Color item)
    {
        if (Colors.Count >= MaxColors)
        {
            throw new ArgumentOutOfRangeException(nameof(item), item,
                $"Color Table cannot have more than {MaxColors} colors.");
        }

        Colors.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        Colors.RemoveAt(index);
    }

    public Color this[int index]
    {
        get => Colors[index];
        set => Colors[index] = value;
    }

    public ColorTableBuilder this[int start, int length] =>
        new(Colors.GetRange(start, length));

    public override bool Equals(object? obj)
    {
        return obj switch
        {
            ColorTableBuilder colorTable => Colors.SequenceEqual(colorTable),
            ColorTable colorTable => Colors.SequenceEqual(colorTable),
            IEnumerable<Color> colors => Colors.SequenceEqual(colors),
            byte[] data => data.Length % 3 == 0 &&
                           Colors.SequenceEqual(ReadBytes(data)),
            _ => false
        };
    }

    public bool Equals(ColorTableBuilder other)
    {
        return Colors.SequenceEqual(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Colors);
    }

    public override string ToString()
    {
        StringBuilder builder = new();
        builder.Append("Color Table Builder: [");
        for (int i = 0; i < Colors.Count; i++)
        {
            builder.Append(Colors[i]);
            if (i < Colors.Count - 1)
            {
                builder.AppendLine(",");
            }
        }

        builder.Append(']');
        return builder.ToString();
    }

    public static bool operator ==(ColorTableBuilder left,
        ColorTableBuilder right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ColorTableBuilder left,
        ColorTableBuilder right)
    {
        return !left.Equals(right);
    }

    public static bool operator ==(ColorTableBuilder left,
        IEnumerable<Color> right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ColorTableBuilder left,
        IEnumerable<Color> right)
    {
        return !left.Equals(right);
    }

    public static bool operator ==(IEnumerable<Color> left,
        ColorTableBuilder right)
    {
        return right.Equals(left);
    }

    public static bool operator !=(IEnumerable<Color> left,
        ColorTableBuilder right)
    {
        return !right.Equals(left);
    }

    public static bool operator ==(ColorTableBuilder left, byte[] right)
    {
        return right.Length % 3 == 0 && left.Equals(ReadBytes(right));
    }

    public static bool operator !=(ColorTableBuilder left, byte[] right)
    {
        return !(left == right);
    }

    public static bool operator ==(byte[] left, ColorTableBuilder right)
    {
        return left.Length % 3 == 0 && right.Equals(ReadBytes(left));
    }

    public static bool operator !=(byte[] left, ColorTableBuilder right)
    {
        return !(left == right);
    }

    public static bool operator ==(ColorTableBuilder left, ColorTable right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ColorTableBuilder left, ColorTable right)
    {
        return !left.Equals(right);
    }

    public static bool operator ==(ColorTable left, ColorTableBuilder right)
    {
        return right.Equals(left);
    }

    public static bool operator !=(ColorTable left, ColorTableBuilder right)
    {
        return !right.Equals(left);
    }

    public static explicit operator List<Color>(
        ColorTableBuilder colorTableBuilder)
    {
        return colorTableBuilder.Colors;
    }

    public static explicit operator ColorTableBuilder(List<Color> colors)
    {
        return new ColorTableBuilder(colors);
    }

    public static explicit operator ColorTableBuilder(Color[] colors)
    {
        return new ColorTableBuilder(colors);
    }

    public static explicit operator byte[](ColorTableBuilder colorTableBuilder)
    {
        return WriteBytes(colorTableBuilder);
    }

    public static explicit operator ColorTableBuilder(byte[] data)
    {
        return ReadBytes(data);
    }

    public ColorTable ToColorTable()
    {
        return new ColorTable(this);
    }

    public static bool IsValidNumberOfColors(int count)
    {
        return count is >= 0 and <= MaxColors;
    }

    public static bool IsValidNumberOfColors(IEnumerable<Color> colors)
    {
        return IsValidNumberOfColors(colors.Count());
    }

    public static bool IsValidNumberOfColorsForColorTableExport(
        ColorTableBuilder colorTable)
    {
        return ColorTable.IsValidNumberOfColors(colorTable);
    }

    public static bool IsValidNumberOfColorsForColorTableExport(
        ColorTable colorTable)
    {
        return IsValidNumberOfColorsForColorTableExport(
            (ColorTableBuilder)colorTable);
    }

    public static bool IsValidNumberOfColorsForColorTableExport(
        IEnumerable<Color> colors)
    {
        return IsValidNumberOfColorsForColorTableExport(
            new ColorTableBuilder(colors));
    }

    public static bool IsValidNumberOfColorsForColorTableExport(
        params Color[] colors)
    {
        return IsValidNumberOfColorsForColorTableExport(
            new ColorTableBuilder(colors));
    }

    public static bool IsValidNumberOfColorsForColorTableExport(byte[] data)
    {
        return IsValidNumberOfColorsForColorTableExport(ReadBytes(data));
    }

    public bool IsValidNumberOfColorsForColorTableExport()
    {
        return IsValidNumberOfColorsForColorTableExport(this);
    }

    public static explicit operator ColorTable(
        ColorTableBuilder colorTableBuilder)
    {
        return colorTableBuilder.ToColorTable();
    }

    public static explicit operator ColorTableBuilder(ColorTable colorTable)
    {
        return new ColorTableBuilder(colorTable);
    }
}