using System.Globalization;

namespace GifHarness.Components.Colors;

/// <summary>
///     Represents a color with red, green, and blue components
///     that are each 8-bit unsigned integers.
///     This struct is intended to be used in the context of
///     GIF files, where colors are represented as 3-byte
///     sequences of red, green, and blue components.
/// </summary>
/// <param name="redComponent">
///     The red component of the color.
/// </param>
/// <param name="greenComponent">
///     The green component of the color.
/// </param>
/// <param name="blueComponent">
///     The blue component of the color.
/// </param>
public struct Color(byte redComponent, byte greenComponent, byte blueComponent)
    : IByteSerializable<Color>
{
    /// <summary>
    ///     The red component of the color.
    /// </summary>
    public byte RedComponent { get; set; } = redComponent;

    /// <summary>
    ///     The green component of the color.
    /// </summary>
    public byte GreenComponent { get; set; } = greenComponent;

    /// <summary>
    ///     The blue component of the color.
    /// </summary>
    public byte BlueComponent { get; set; } = blueComponent;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Color" /> struct
    ///     from an existing <see cref="Color" /> instance.
    ///     This constructor is a copy constructor.
    /// </summary>
    /// <param name="color">
    ///     The <see cref="Color" /> instance to copy.
    /// </param>
    public Color(Color color)
        : this(color.RedComponent, color.GreenComponent, color.BlueComponent)
    { }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Color" /> struct
    ///     from an existing <see cref="System.Drawing.Color" /> instance.
    ///
    ///     The alpha component of the <paramref name="drawingColor" /> must be 255.
    /// </summary>
    /// <param name="drawingColor">
    ///     The <see cref="System.Drawing.Color" /> instance to copy.
    /// </param>
    /// <exception cref="ArgumentException">
    ///     Thrown if the alpha component of the <paramref name="drawingColor" /> is not 255.
    /// </exception>
    public Color(System.Drawing.Color drawingColor)
        : this(drawingColor.R, drawingColor.G, drawingColor.B)
    {
        if (drawingColor.A != 255)
            throw new ArgumentException(
                "Alpha component must be 255.",
                nameof(drawingColor)
            );
    }

    /// <summary>
    ///     Reads a byte array and returns a <see cref="Color" />.
    ///     The first byte is the red component,
    ///     the second byte is the green component,
    ///     and the third byte is the blue component.
    ///     The byte array must have a length of 3.
    /// </summary>
    /// <param name="data">
    ///     The byte array to read.
    /// </param>
    /// <returns>
    ///     The <see cref="Color" /> represented by the byte array.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the byte array is not of length 3.
    /// </exception>
    public static Color ReadBytes(byte[] data)
    {
        const int expectedLength = 3;
        if (data.Length != expectedLength)
            throw new ArgumentException(
                "Color data must have a length of 3.",
                nameof(data)
            );

        return new Color(data[0], data[1], data[2]);
    }

    /// <summary>
    ///     Writes a <see cref="Color" /> to a byte array.
    ///     Note that the byte array will have a length of 3.
    ///     The first byte is the red component,
    ///     the second byte is the green component,
    ///     and the third byte is the blue component.
    ///     The byte array can be read back into a <see cref="Color" />
    ///     using the <see cref="ReadBytes" /> method.
    ///     This is guaranteed to be equal to the original <see cref="Color" />.
    /// </summary>
    /// <param name="obj">
    ///     The <see cref="Color" /> to write to a byte array.
    /// </param>
    /// <returns>
    ///     A byte array representing the <see cref="Color" />.
    /// </returns>
    public static byte[] WriteBytes(Color obj)
    {
        return [obj.RedComponent, obj.GreenComponent, obj.BlueComponent];
    }

    /// <summary>
    ///     Writes this <see cref="Color"/> to a byte array.
    ///     Note that the byte array will have a length of 3.
    ///     The first byte is the red component,
    ///     the second byte is the green component,
    ///     and the third byte is the blue component.
    ///     The byte array can be read back into a <see cref="Color" />
    ///     using the <see cref="ReadBytes" /> method.
    ///     This is guaranteed to be equal to the original <see cref="Color" />.
    /// </summary>
    /// <returns>
    ///     A byte array representing the <see cref="Color" />.
    /// </returns>
    public byte[] WriteBytes()
    {
        return WriteBytes(this);
    }

    /// <summary>
    ///     Determines whether the specified object is equal to the current object.
    ///     The object is considered equal if it is
    ///     a <see cref="Color" />,
    ///     a <see cref="System.Drawing.Color" />,
    ///     or a byte array.
    ///     Any other type will return false (including null).
    ///     If the object is a <see cref="Color" />,
    ///     the red, green, and blue components must be equal.
    ///     If the object is a <see cref="System.Drawing.Color" />,
    ///     the red, green, and blue components must be equal,
    ///     and the alpha component of the <paramref name="obj" /> must be 255.
    ///     If the object is a byte array,
    ///     the byte array must be of length 3.
    ///     The first byte must be the red component
    ///     and must be equal to its value,
    ///     the second byte must be the green component
    ///     and must be equal to its value,
    ///     and the third byte must be the blue component
    ///     and must be equal to its value.
    /// </summary>
    /// <param name="obj">
    ///     The object to compare with the current object.
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the specified object
    ///     is equal to the current object;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            Color color => RedComponent == color.RedComponent &&
                           GreenComponent == color.GreenComponent &&
                           BlueComponent == color.BlueComponent,
            System.Drawing.Color drawingColor =>
                RedComponent == drawingColor.R &&
                GreenComponent == drawingColor.G &&
                BlueComponent == drawingColor.B &&
                drawingColor.A == 255,
            byte[] data => data.Length == 3 && Equals(ReadBytes(data)),
            _ => false
        };
    }

    /// <summary>
    ///     Determines whether the specified <see cref="Color" />
    ///     is equal to the current <see cref="Color" />.
    ///     The <see cref="RedComponent" />, <see cref="GreenComponent" /> and <see cref="BlueComponent" />
    ///     components must be equal.
    /// </summary>
    /// <param name="other">
    ///     The <see cref="Color" /> to compare with the current <see cref="Color" />.
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the specified <see cref="Color" />
    ///     is equal to the current <see cref="Color" />;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public bool Equals(Color other)
    {
        return RedComponent == other.RedComponent &&
               GreenComponent == other.GreenComponent &&
               BlueComponent == other.BlueComponent;
    }

    /// <summary>
    ///     Serves as the default hash function.
    ///     WARNING: The red, green and blue components are used in the calculation
    ///     of the hash code but are settable.
    ///     As such, be careful when using this method in a HashSet or Dictionary.
    /// </summary>
    /// <returns>
    ///     A hash code for the current object.
    /// </returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(RedComponent, GreenComponent, BlueComponent);
    }

    /// <summary>
    ///     Determines whether two <see cref="Color" /> instances are equal.
    ///     The <see cref="RedComponent" />, <see cref="GreenComponent" /> and <see cref="BlueComponent" />
    ///     components must be equal.
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The second <see cref="Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two <see cref="Color" /> instances are equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator ==(Color left, Color right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Determines whether two <see cref="Color" /> instances are not equal.
    ///     At least one of the <see cref="RedComponent" />,
    ///     <see cref="GreenComponent" /> and <see cref="BlueComponent" />
    ///     components must not be equal.
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The second <see cref="Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two <see cref="Color" /> instances are not equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator !=(Color left, Color right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    ///     Determines whether a <see cref="Color" /> instance is equal to a
    ///     <see cref="System.Drawing.Color" /> instance.
    ///     The <see cref="RedComponent" />, <see cref="GreenComponent" /> and <see cref="BlueComponent" />
    ///     components must be equal.
    ///     The alpha component of the <paramref name="right" /> must be 255.
    /// </summary>
    /// <param name="left">
    ///     The <see cref="Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The <see cref="System.Drawing.Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two instances are equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator ==(Color left, System.Drawing.Color right)
    {
        return right.A == 255 && left.Equals(right);
    }

    /// <summary>
    ///     Determines whether a <see cref="Color" /> instance is not equal to a
    ///     <see cref="System.Drawing.Color" /> instance.
    ///     The alpha component of the <paramref name="right" /> must not be 255
    ///     or at least one of the <see cref="RedComponent" />,
    ///     <see cref="GreenComponent" /> and <see cref="BlueComponent" /> components must not be equal.
    /// </summary>
    /// <param name="left">
    ///     The <see cref="Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The <see cref="System.Drawing.Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two instances are not equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator !=(Color left, System.Drawing.Color right)
    {
        return right.A != 255 || !left.Equals(right);
    }

    /// <summary>
    ///     Determines whether a <see cref="System.Drawing.Color" /> instance is equal to a
    ///     <see cref="Color" /> instance.
    ///     The <see cref="RedComponent" />, <see cref="GreenComponent" /> and <see cref="BlueComponent" />
    ///     components must be equal.
    ///     The alpha component of the <paramref name="left" /> must be 255.
    /// </summary>
    /// <param name="left">
    ///     The <see cref="System.Drawing.Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The <see cref="Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two instances are equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator ==(System.Drawing.Color left, Color right)
    {
        return left.A == 255 && right.Equals(left);
    }

    /// <summary>
    ///     Determines whether a <see cref="System.Drawing.Color" /> instance is not equal to a
    ///     <see cref="Color" /> instance.
    ///     The alpha component of the <paramref name="left" /> must not be 255
    ///     or at least one of the <see cref="RedComponent" />,
    ///     <see cref="GreenComponent" /> and <see cref="BlueComponent" /> components must not be equal.
    /// </summary>
    /// <param name="left">
    ///     The <see cref="System.Drawing.Color" /> to compare (the left operand).
    /// </param>
    /// <param name="right">
    ///     The <see cref="Color" /> to compare (the right operand).
    /// </param>
    /// <returns>
    ///     <see langword="true" /> if the two instances are not equal;
    ///     <see langword="false" /> otherwise.
    /// </returns>
    public static bool operator !=(System.Drawing.Color left, Color right)
    {
        return left.A != 255 || !right.Equals(left);
    }

    /// <summary>
    ///     Returns a string that represents the current object.
    ///     The string is in the format
    ///     "Color: (R: <see cref="RedComponent" />, G: <see cref="GreenComponent" />, B: <see cref="BlueComponent" />)".
    /// </summary>
    /// <returns>
    ///     A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
        return
            $"Color: (R: {RedComponent}, G: {GreenComponent}, B: {BlueComponent})";
    }

    /// <summary>
    ///     Converts a byte array to a <see cref="Color" />.
    ///     The byte array must have a length of 3.
    ///     The first byte is the red component,
    ///     the second byte is the green component,
    ///     and the third byte is the blue component.
    /// </summary>
    /// <param name="data">
    ///     The byte array to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="Color" /> represented by the byte array.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the byte array is not of length 3.
    /// </exception>
    public static explicit operator Color(byte[] data)
    {
        return ReadBytes(data);
    }

    /// <summary>
    ///     Converts a <see cref="Color" /> to a byte array.
    ///     The byte array will have a length of 3.
    ///     The first byte is the red component,
    ///     the second byte is the green component,
    ///     and the third byte is the blue component.
    ///     The byte array can be read back into a
    ///     <see cref="Color" /> equal to the original
    ///     using the <see cref="ReadBytes" /> method.
    /// </summary>
    /// <param name="obj">
    ///     The <see cref="Color" /> to convert.
    /// </param>
    /// <returns>
    ///     A byte array representing the <see cref="Color" />.
    /// </returns>
    public static explicit operator byte[](Color obj)
    {
        return WriteBytes(obj);
    }

    /// <summary>
    ///     Converts a <see cref="Color" /> to a <see cref="System.Drawing.Color" />.
    /// </summary>
    /// <param name="color">
    ///     The <see cref="Color" /> to convert.
    ///     The alpha component of the <see cref="System.Drawing.Color" /> will be 255.
    /// </param>
    /// <returns>
    ///     A <see cref="System.Drawing.Color" /> equal to the <see cref="Color" />.
    /// </returns>
    public static implicit operator System.Drawing.Color(Color color)
    {
        return System.Drawing.Color.FromArgb(color.RedComponent,
            color.GreenComponent,
            color.BlueComponent);
    }

    /// <summary>
    ///     Converts a <see cref="System.Drawing.Color" /> to a <see cref="Color" />.
    ///
    ///     The alpha component of the <paramref name="drawingColor" /> must be 255.
    /// </summary>
    /// <param name="drawingColor">
    ///     The <see cref="System.Drawing.Color" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="Color" /> equal to the <see cref="System.Drawing.Color" />.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the alpha component of the <paramref name="drawingColor" /> is not 255.
    /// </exception>
    public static implicit operator Color(System.Drawing.Color drawingColor)
    {
        return new Color(drawingColor);
    }

    /// <summary>
    ///     Converts a tuple of red, green, and blue components to a <see cref="Color" />.
    ///
    ///     The first item in the tuple is the red component,
    ///     the second item is the green component,
    ///     and the third item is the blue component.
    /// </summary>
    /// <param name="tuple">
    ///     The tuple to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="Color" /> equal to the tuple.
    /// </returns>
    public static implicit operator Color(
        (byte red, byte green, byte blue) tuple)
    {
        return new Color(tuple.red, tuple.green, tuple.blue);
    }

    /// <summary>
    ///     Converts a <see cref="Color" /> to a tuple of red, green, and blue components.
    /// </summary>
    /// <param name="color">
    ///     The <see cref="Color" /> to convert.
    /// </param>
    /// <returns>
    ///     A tuple of red, green, and blue components equal to the <see cref="Color" />.
    ///
    ///     The first item in the tuple is the red component,
    ///     the second item is the green component,
    ///     and the third item is the blue component.
    /// </returns>
    /// <remarks>
    ///     This method is used to deconstruct a <see cref="Color" /> into a tuple.
    ///     But unlike the <see cref="Deconstruct" /> method, this method is used
    ///     when the assigned tuple is a variable and not directly in a deconstruction.
    /// </remarks>
    public static implicit operator (byte red, byte green, byte blue)(
        Color color)
    {
        return (color.RedComponent, color.GreenComponent, color.BlueComponent);
    }

    /// <summary>
    ///     Converts a <see cref="Color" /> to a tuple of red, green, and blue components.
    /// </summary>
    /// <param name="red">
    ///     The red component of the <see cref="Color" />.
    /// </param>
    /// <param name="green">
    ///     The green component of the <see cref="Color" />.
    /// </param>
    /// <param name="blue">
    ///     The blue component of the <see cref="Color" />.
    /// </param>
    /// <remarks>
    ///     This method is used to deconstruct a <see cref="Color" /> into a tuple.
    ///     This method is used when the assigned tuple is directly in a deconstruction
    ///     unlike the implicit operator which is used when the assigned tuple is a variable.
    /// </remarks>
    public void Deconstruct(out byte red, out byte green, out byte blue)
    {
        red = RedComponent;
        green = GreenComponent;
        blue = BlueComponent;
    }

    /// <summary>
    ///     Instantiates a new <see cref="Color" /> from the specified
    ///     red, green, and blue components.
    /// </summary>
    /// <param name="red">
    ///     The red component of the color.
    /// </param>
    /// <param name="green">
    ///     The green component of the color.
    /// </param>
    /// <param name="blue">
    ///     The blue component of the color.
    /// </param>
    /// <returns>
    ///     A new <see cref="Color" /> instance with the specified components.
    /// </returns>
    public static Color FromRgb(byte red, byte green, byte blue)
    {
        return new Color(red, green, blue);
    }

    /// <summary>
    ///     Instantiates a new <see cref="Color" /> from the specified
    ///     <see cref="System.Drawing.Color" />.
    ///
    ///     The alpha component of the <paramref name="drawingColor" /> must be 255.
    ///     The red, green, and blue components of the <see cref="Color" />
    ///     will be equal to the red, green, and blue components of the
    ///     <paramref name="drawingColor" />.
    ///
    ///     If the alpha component of the <paramref name="drawingColor" /> is not 255,
    ///     an <see cref="ArgumentException" /> will be thrown.
    /// </summary>
    /// <param name="drawingColor">
    ///     The <see cref="System.Drawing.Color" /> to convert.
    /// </param>
    /// <returns>
    ///     A new <see cref="Color" /> instance with the same components
    ///     as the <paramref name="drawingColor" />.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the alpha component of the <paramref name="drawingColor" /> is not 255.
    /// </exception>
    public static Color FromRgb(System.Drawing.Color drawingColor)
    {
        return new Color(drawingColor);
    }

    /// <summary>
    ///     Instantiates a new <see cref="Color" /> from the specified
    ///     red, green, and blue components in the form of a color string.
    ///
    ///     The color string must be exactly 6, 7, 8, or 9 characters long.
    ///     If the string is 7 or 9 characters long, it must start with '#'.
    ///
    ///     The first two non-hash characters are the red component in hexadecimal.
    ///     The next two characters are the green component in hexadecimal.
    ///     The following two characters are the blue component in hexadecimal.
    /// 
    ///     If the string is 8 or 9 characters long, the last two characters
    ///     must be 'ff' or 'FF' indicating an alpha value of 255.
    /// </summary>
    /// <param name="colorString">
    ///     The color string to convert.
    /// </param>
    /// <returns>
    ///     A new <see cref="Color" /> instance with the components.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the color length is not 6, 7, 8, or 9 characters long.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown if the color string is 7 characters long or 9 characters long
    ///     and does not start with '#'.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown if the alpha component is not 'ff' or 'FF'.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Thrown if the red, green, or blue component is not a 
    ///     2-digit hexadecimal number.
    /// </exception>
    public static Color FromRgbColorString(string colorString)
    {
        const int rgbStringLengthWithHashWithoutAlpha = 7;
        const int rgbStringLengthWithoutHashWithoutAlpha = 6;
        const int rgbStringLengthWithHashWithAlpha = 9;
        const int rgbStringLengthWithoutHashWithAlpha = 8;


        if (colorString.Length is not rgbStringLengthWithHashWithoutAlpha
            and not rgbStringLengthWithoutHashWithoutAlpha
            and not rgbStringLengthWithHashWithAlpha
            and not rgbStringLengthWithoutHashWithAlpha)
            throw new ArgumentException(
                "Color string must be exactly 6 characters long." +
                "(7 characters if the string starts with '#')\n" +
                "An 8 characters long (9 characters if the string starts with '#') " +
                "color string is tolerated if the last 2 characters are 'ff' or 'FF' " +
                "indicating an alpha value of 255.\n" +
                $"The provided length was {colorString.Length}.",
                nameof(colorString)
            );

        char firstChar = colorString[0];
        if (colorString.Length is rgbStringLengthWithHashWithoutAlpha or
                rgbStringLengthWithHashWithAlpha &&
            firstChar != '#')
            throw new ArgumentException(
                "Color string must start with '#' if it is 7 characters long.",
                nameof(colorString)
            );

        bool hasHash = firstChar == '#';
        bool hasAlpha = colorString.Length is rgbStringLengthWithHashWithAlpha
            or
            rgbStringLengthWithoutHashWithAlpha;

        if (hasHash)
            colorString = colorString[1..];

        string redString = colorString[..2];
        string greenString = colorString[2..4];
        string blueString = colorString[4..6];

        if (hasAlpha)
        {
            string alphaString = colorString[6..];
            if (alphaString is not "ff" and not "FF")
                throw new ArgumentException(
                    "Invalid alpha component: " +
                    $"{alphaString} (must be 'ff' or 'FF').",
                    nameof(colorString)
                );
        }

        ValidateRgbStringComponentSubString(redString, "red", out byte red);
        ValidateRgbStringComponentSubString(greenString, "green",
            out byte green);
        ValidateRgbStringComponentSubString(blueString, "blue", out byte blue);

        return new Color(red, green, blue);
    }

    /// <summary>
    ///     Validates a red, green, or blue component substring
    ///
    ///     This is a helper method for the <see cref="FromRgbColorString" /> method.
    ///
    ///     The component must be a 2-digit hexadecimal number.
    /// </summary>
    /// <param name="component">
    ///     The red, green, or blue component substring
    /// </param>
    /// <param name="name">
    ///    The name of the component
    /// </param>
    /// <param name="value">
    ///     The byte value of the component (out parameter)
    /// </param>
    /// <exception cref="ArgumentException">
    ///     Thrown if the component is not a 2-digit hexadecimal number.
    /// </exception>
    private static void ValidateRgbStringComponentSubString(string component,
        string name, out byte value)
    {
        if (!byte.TryParse(component, NumberStyles.HexNumber, null, out value))
            throw new ArgumentException(
                $"Invalid {name} component: {component}" +
                " (must be a 2-digit hexadecimal number)."
            );
    }

    /// <summary>
    ///     Converts a <see cref="Color" /> to a color string.
    ///
    ///     The color string is in the "RRGGBB", "RRGGBBAA",
    ///     "#RRGGBB", or "#RRGGBBAA" formats.
    ///
    ///     The red, green, and blue components are represented
    ///     as 2-digit hexadecimal numbers.
    ///
    ///     Optionally, the alpha component can be included.
    ///     Note that the alpha component is always "FF" or "ff" (255).
    ///
    ///     Optionally, a hash can be included at the beginning of the string.
    ///
    ///     The case of the hexadecimal numbers can be controlled.
    ///     By default, the hexadecimal numbers are in uppercase.
    /// </summary>
    /// <param name="includeHash">
    ///     Whether to include a hash at the beginning of the string.
    ///     Default is <see langword="false" />.
    /// </param>
    /// <param name="includeAlpha">
    ///     Whether to include the alpha component at the end of the string.
    ///     Default is <see langword="false" />.
    ///
    ///     Note that the alpha component is always "FF" or "ff" (255).
    /// </param>
    /// <param name="useUppercase">
    ///     Whether to use uppercase or lowercase hexadecimal numbers.
    ///
    ///     If <see langword="true" />, the hexadecimal numbers will be uppercase.
    ///     If <see langword="false" />, the hexadecimal numbers will be lowercase.
    ///
    ///     Default is <see langword="true" />.
    /// </param>
    /// <returns>
    ///     A color string representing the <see cref="Color" />.
    /// </returns>
    public string ToRgbColorString(bool useUppercase = true,
        bool includeHash = false,
        bool includeAlpha = false)
    {
        string redString = RedComponent.ToString(useUppercase ? "X2" : "x2");
        string greenString =
            GreenComponent.ToString(useUppercase ? "X2" : "x2");
        string blueString = BlueComponent.ToString(useUppercase ? "X2" : "x2");

        if (!includeAlpha)
            return includeHash
                ? $"#{redString}{greenString}{blueString}"
                : $"{redString}{greenString}{blueString}";

        string alphaString = useUppercase ? "FF" : "ff";
        return includeHash
            ? $"#{redString}{greenString}{blueString}{alphaString}"
            : $"{redString}{greenString}{blueString}{alphaString}";
    }

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Alice Blue (RGB: 240, 248, 255, #F0F8FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Alice Blue (RGB: 240, 248, 255, #F0F8FF).
    /// </returns>
    public static Color AliceBlue => new(240, 248, 255);

    /// <summary>
    ///     Determines whether this <see cref="Color" /> is equal to
    ///     <see cref="AliceBlue" /> (RGB: 240, 248, 255, #F0F8FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> is equal to
    ///     <see cref="AliceBlue" />; <see langword="false" /> otherwise.
    /// </returns>
    public bool IsAliceBlue => this == AliceBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Antique White (RGB: 250, 235, 215, #FAEBD7).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Antique White (RGB: 250, 235, 215, #FAEBD7).
    /// </returns>
    public static Color AntiqueWhite => new(250, 235, 215);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="AntiqueWhite" /> (RGB: 250, 235, 215, #FAEBD7).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="AntiqueWhite" /> (RGB: 250, 235, 215, #FAEBD7); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsAntiqueWhite => this == AntiqueWhite;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Aqua (RGB: 0, 255, 255, #00FFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Aqua (RGB: 0, 255, 255, #00FFFF).
    /// </returns>
    public static Color Aqua => new(0, 255, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Aqua" /> (RGB: 0, 255, 255, #00FFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Aqua" /> (RGB: 0, 255, 255, #00FFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsAqua => this == Aqua;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Aquamarine (RGB: 127, 255, 212, #7FFFD4).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Aquamarine (RGB: 127, 255, 212, #7FFFD4).
    /// </returns>
    public static Color Aquamarine => new(127, 255, 212);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Aquamarine" /> (RGB: 127, 255, 212, #7FFFD4).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Aquamarine" /> (RGB: 127, 255, 212, #7FFFD4); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsAquamarine => this == Aquamarine;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Azure (RGB: 240, 255, 255, #F0FFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Azure (RGB: 240, 255, 255, #F0FFFF).
    /// </returns>
    public static Color Azure => new(240, 255, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Azure" /> (RGB: 240, 255, 255, #F0FFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Azure" /> (RGB: 240, 255, 255, #F0FFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsAzure => this == Azure;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Beige (RGB: 245, 245, 220, #F5F5DC).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Beige (RGB: 245, 245, 220, #F5F5DC).
    /// </returns>
    public static Color Beige => new(245, 245, 220);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Beige" /> (RGB: 245, 245, 220, #F5F5DC).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Beige" /> (RGB: 245, 245, 220, #F5F5DC); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBeige => this == Beige;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Bisque (RGB: 255, 228, 196, #FFE4C4).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Bisque (RGB: 255, 228, 196, #FFE4C4).
    /// </returns>
    public static Color Bisque => new(255, 228, 196);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Bisque" /> (RGB: 255, 228, 196, #FFE4C4).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Bisque" /> (RGB: 255, 228, 196, #FFE4C4); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBisque => this == Bisque;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Black (RGB: 0, 0, 0, #000000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Black (RGB: 0, 0, 0, #000000).
    /// </returns>
    public static Color Black => new(0, 0, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Black" /> (RGB: 0, 0, 0, #000000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Black" /> (RGB: 0, 0, 0, #000000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBlack => this == Black;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Blanched Almond (RGB: 255, 235, 205, #FFEBCD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Blanched Almond (RGB: 255, 235, 205, #FFEBCD).
    /// </returns>
    public static Color BlanchedAlmond => new(255, 235, 205);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="BlanchedAlmond" /> (RGB: 255, 235, 205, #FFEBCD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="BlanchedAlmond" /> (RGB: 255, 235, 205, #FFEBCD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBlanchedAlmond => this == BlanchedAlmond;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Blue (RGB: 0, 0, 255, #0000FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Blue (RGB: 0, 0, 255, #0000FF).
    /// </returns>
    public static Color Blue => new(0, 0, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Blue" /> (RGB: 0, 0, 255, #0000FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Blue" /> (RGB: 0, 0, 255, #0000FF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBlue => this == Blue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Blue Violet (RGB: 138, 43, 226, #8A2BE2).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Blue Violet (RGB: 138, 43, 226, #8A2BE2).
    /// </returns>
    public static Color BlueViolet => new(138, 43, 226);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="BlueViolet" /> (RGB: 138, 43, 226, #8A2BE2).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="BlueViolet" /> (RGB: 138, 43, 226, #8A2BE2); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBlueViolet => this == BlueViolet;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Brown (RGB: 165, 42, 42, #A52A2A).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Brown (RGB: 165, 42, 42, #A52A2A).
    /// </returns>
    public static Color Brown => new(165, 42, 42);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Brown" /> (RGB: 165, 42, 42, #A52A2A).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Brown" /> (RGB: 165, 42, 42, #A52A2A); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBrown => this == Brown;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Burly Wood (RGB: 222, 184, 135, #DEB887).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Burly Wood (RGB: 222, 184, 135, #DEB887).
    /// </returns>
    public static Color BurlyWood => new(222, 184, 135);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="BurlyWood" /> (RGB: 222, 184, 135, #DEB887).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="BurlyWood" /> (RGB: 222, 184, 135, #DEB887); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsBurlyWood => this == BurlyWood;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Cadet Blue (RGB: 95, 158, 160, #5F9EA0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Cadet Blue (RGB: 95, 158, 160, #5F9EA0).
    /// </returns>
    public static Color CadetBlue => new(95, 158, 160);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="CadetBlue" /> (RGB: 95, 158, 160, #5F9EA0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="CadetBlue" /> (RGB: 95, 158, 160, #5F9EA0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCadetBlue => this == CadetBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Chartreuse (RGB: 127, 255, 0, #7FFF00).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Chartreuse (RGB: 127, 255, 0, #7FFF00).
    /// </returns>
    public static Color Chartreuse => new(127, 255, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Chartreuse" /> (RGB: 127, 255, 0, #7FFF00).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Chartreuse" /> (RGB: 127, 255, 0, #7FFF00); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsChartreuse => this == Chartreuse;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Chocolate (RGB: 210, 105, 30, #D2691E).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Chocolate (RGB: 210, 105, 30, #D2691E).
    /// </returns>
    public static Color Chocolate => new(210, 105, 30);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Chocolate" /> (RGB: 210, 105, 30, #D2691E).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Chocolate" /> (RGB: 210, 105, 30, #D2691E); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsChocolate => this == Chocolate;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Coral (RGB: 255, 127, 80, #FF7F50).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Coral (RGB: 255, 127, 80, #FF7F50).
    /// </returns>
    public static Color Coral => new(255, 127, 80);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Coral" /> (RGB: 255, 127, 80, #FF7F50).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Coral" /> (RGB: 255, 127, 80, #FF7F50); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCoral => this == Coral;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Cornflower Blue (RGB: 100, 149, 237, #6495ED).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Cornflower Blue (RGB: 100, 149, 237, #6495ED).
    /// </returns>
    public static Color CornflowerBlue => new(100, 149, 237);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="CornflowerBlue" /> (RGB: 100, 149, 237, #6495ED).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="CornflowerBlue" /> (RGB: 100, 149, 237, #6495ED); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCornflowerBlue => this == CornflowerBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Cornsilk (RGB: 255, 248, 220, #FFF8DC).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Cornsilk (RGB: 255, 248, 220, #FFF8DC).
    /// </returns>
    public static Color Cornsilk => new(255, 248, 220);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Cornsilk" /> (RGB: 255, 248, 220, #FFF8DC).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Cornsilk" /> (RGB: 255, 248, 220, #FFF8DC); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCornsilk => this == Cornsilk;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Crimson (RGB: 220, 20, 60, #DC143C).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Crimson (RGB: 220, 20, 60, #DC143C).
    /// </returns>
    public static Color Crimson => new(220, 20, 60);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Crimson" /> (RGB: 220, 20, 60, #DC143C).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Crimson" /> (RGB: 220, 20, 60, #DC143C); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCrimson => this == Crimson;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Cyan (RGB: 0, 255, 255, #00FFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Cyan (RGB: 0, 255, 255, #00FFFF).
    /// </returns>
    public static Color Cyan => new(0, 255, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Cyan" /> (RGB: 0, 255, 255, #00FFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Cyan" /> (RGB: 0, 255, 255, #00FFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsCyan => this == Cyan;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Blue (RGB: 0, 0, 139, #00008B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Blue (RGB: 0, 0, 139, #00008B).
    /// </returns>
    public static Color DarkBlue => new(0, 0, 139);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkBlue" /> (RGB: 0, 0, 139, #00008B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkBlue" /> (RGB: 0, 0, 139, #00008B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkBlue => this == DarkBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Cyan (RGB: 0, 139, 139, #008B8B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Cyan (RGB: 0, 139, 139, #008B8B).
    /// </returns>
    public static Color DarkCyan => new(0, 139, 139);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkCyan" /> (RGB: 0, 139, 139, #008B8B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkCyan" /> (RGB: 0, 139, 139, #008B8B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkCyan => this == DarkCyan;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Goldenrod (RGB: 184, 134, 11, #B8860B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Goldenrod (RGB: 184, 134, 11, #B8860B).
    /// </returns>
    public static Color DarkGoldenrod => new(184, 134, 11);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGoldenrod" /> (RGB: 184, 134, 11, #B8860B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGoldenrod" /> (RGB: 184, 134, 11, #B8860B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkGoldenrod => this == DarkGoldenrod;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Gray (RGB: 169, 169, 169, #A9A9A9).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Gray (RGB: 169, 169, 169, #A9A9A9).
    /// </returns>
    public static Color DarkGray => new(169, 169, 169);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGray" /> (RGB: 169, 169, 169, #A9A9A9).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGray" /> (RGB: 169, 169, 169, #A9A9A9); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkGray => this == DarkGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Green (RGB: 0, 100, 0, #006400).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Green (RGB: 0, 100, 0, #006400).
    /// </returns>
    public static Color DarkGreen => new(0, 100, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGreen" /> (RGB: 0, 100, 0, #006400).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkGreen" /> (RGB: 0, 100, 0, #006400); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkGreen => this == DarkGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Khaki (RGB: 189, 183, 107, #BDB76B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Khaki (RGB: 189, 183, 107, #BDB76B).
    /// </returns>
    public static Color DarkKhaki => new(189, 183, 107);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkKhaki" /> (RGB: 189, 183, 107, #BDB76B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkKhaki" /> (RGB: 189, 183, 107, #BDB76B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkKhaki => this == DarkKhaki;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Magenta (RGB: 139, 0, 139, #8B008B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Magenta (RGB: 139, 0, 139, #8B008B).
    /// </returns>
    public static Color DarkMagenta => new(139, 0, 139);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkMagenta" /> (RGB: 139, 0, 139, #8B008B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkMagenta" /> (RGB: 139, 0, 139, #8B008B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkMagenta => this == DarkMagenta;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Olive Green (RGB: 85, 107, 47, #556B2F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Olive Green (RGB: 85, 107, 47, #556B2F).
    /// </returns>
    public static Color DarkOliveGreen => new(85, 107, 47);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOliveGreen" /> (RGB: 85, 107, 47, #556B2F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOliveGreen" /> (RGB: 85, 107, 47, #556B2F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkOliveGreen => this == DarkOliveGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Orange (RGB: 255, 140, 0, #FF8C00).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Orange (RGB: 255, 140, 0, #FF8C00).
    /// </returns>
    public static Color DarkOrange => new(255, 140, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOrange" /> (RGB: 255, 140, 0, #FF8C00).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOrange" /> (RGB: 255, 140, 0, #FF8C00); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkOrange => this == DarkOrange;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Orchid (RGB: 153, 50, 204, #9932CC).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Orchid (RGB: 153, 50, 204, #9932CC).
    /// </returns>
    public static Color DarkOrchid => new(153, 50, 204);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOrchid" /> (RGB: 153, 50, 204, #9932CC).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkOrchid" /> (RGB: 153, 50, 204, #9932CC); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkOrchid => this == DarkOrchid;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Red (RGB: 139, 0, 0, #8B0000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Red (RGB: 139, 0, 0, #8B0000).
    /// </returns>
    public static Color DarkRed => new(139, 0, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkRed" /> (RGB: 139, 0, 0, #8B0000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkRed" /> (RGB: 139, 0, 0, #8B0000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkRed => this == DarkRed;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Salmon (RGB: 233, 150, 122, #E9967A).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Salmon (RGB: 233, 150, 122, #E9967A).
    /// </returns>
    public static Color DarkSalmon => new(233, 150, 122);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSalmon" /> (RGB: 233, 150, 122, #E9967A).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSalmon" /> (RGB: 233, 150, 122, #E9967A); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkSalmon => this == DarkSalmon;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Sea Green (RGB: 143, 188, 139, #8FBC8B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Sea Green (RGB: 143, 188, 139, #8FBC8B).
    /// </returns>
    public static Color DarkSeaGreen => new(143, 188, 139);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSeaGreen" /> (RGB: 143, 188, 139, #8FBC8B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSeaGreen" /> (RGB: 143, 188, 139, #8FBC8B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkSeaGreen => this == DarkSeaGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Slate Blue (RGB: 72, 61, 139, #483D8B).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Slate Blue (RGB: 72, 61, 139, #483D8B).
    /// </returns>
    public static Color DarkSlateBlue => new(72, 61, 139);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSlateBlue" /> (RGB: 72, 61, 139, #483D8B).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSlateBlue" /> (RGB: 72, 61, 139, #483D8B); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkSlateBlue => this == DarkSlateBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Slate Gray (RGB: 47, 79, 79, #2F4F4F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Slate Gray (RGB: 47, 79, 79, #2F4F4F).
    /// </returns>
    public static Color DarkSlateGray => new(47, 79, 79);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSlateGray" /> (RGB: 47, 79, 79, #2F4F4F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkSlateGray" /> (RGB: 47, 79, 79, #2F4F4F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkSlateGray => this == DarkSlateGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Turquoise (RGB: 0, 206, 209, #00CED1).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Turquoise (RGB: 0, 206, 209, #00CED1).
    /// </returns>
    public static Color DarkTurquoise => new(0, 206, 209);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkTurquoise" /> (RGB: 0, 206, 209, #00CED1).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkTurquoise" /> (RGB: 0, 206, 209, #00CED1); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkTurquoise => this == DarkTurquoise;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dark Violet (RGB: 148, 0, 211, #9400D3).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dark Violet (RGB: 148, 0, 211, #9400D3).
    /// </returns>
    public static Color DarkViolet => new(148, 0, 211);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkViolet" /> (RGB: 148, 0, 211, #9400D3).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DarkViolet" /> (RGB: 148, 0, 211, #9400D3); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDarkViolet => this == DarkViolet;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Deep Pink (RGB: 255, 20, 147, #FF1493).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Deep Pink (RGB: 255, 20, 147, #FF1493).
    /// </returns>
    public static Color DeepPink => new(255, 20, 147);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DeepPink" /> (RGB: 255, 20, 147, #FF1493).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DeepPink" /> (RGB: 255, 20, 147, #FF1493); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDeepPink => this == DeepPink;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Deep Sky Blue (RGB: 0, 191, 255, #00BFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Deep Sky Blue (RGB: 0, 191, 255, #00BFFF).
    /// </returns>
    public static Color DeepSkyBlue => new(0, 191, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DeepSkyBlue" /> (RGB: 0, 191, 255, #00BFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DeepSkyBlue" /> (RGB: 0, 191, 255, #00BFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDeepSkyBlue => this == DeepSkyBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dim Gray (RGB: 105, 105, 105, #696969).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dim Gray (RGB: 105, 105, 105, #696969).
    /// </returns>
    public static Color DimGray => new(105, 105, 105);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DimGray" /> (RGB: 105, 105, 105, #696969).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DimGray" /> (RGB: 105, 105, 105, #696969); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDimGray => this == DimGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Dodger Blue (RGB: 30, 144, 255, #1E90FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Dodger Blue (RGB: 30, 144, 255, #1E90FF).
    /// </returns>
    public static Color DodgerBlue => new(30, 144, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="DodgerBlue" /> (RGB: 30, 144, 255, #1E90FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="DodgerBlue" /> (RGB: 30, 144, 255, #1E90FF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsDodgerBlue => this == DodgerBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Firebrick (RGB: 178, 34, 34, #B22222).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Firebrick (RGB: 178, 34, 34, #B22222).
    /// </returns>
    public static Color Firebrick => new(178, 34, 34);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Firebrick" /> (RGB: 178, 34, 34, #B22222).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Firebrick" /> (RGB: 178, 34, 34, #B22222); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsFirebrick => this == Firebrick;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Floral White (RGB: 255, 250, 240, #FFFAF0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Floral White (RGB: 255, 250, 240, #FFFAF0).
    /// </returns>
    public static Color FloralWhite => new(255, 250, 240);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="FloralWhite" /> (RGB: 255, 250, 240, #FFFAF0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="FloralWhite" /> (RGB: 255, 250, 240, #FFFAF0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsFloralWhite => this == FloralWhite;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Forest Green (RGB: 34, 139, 34, #228B22).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Forest Green (RGB: 34, 139, 34, #228B22).
    /// </returns>
    public static Color ForestGreen => new(34, 139, 34);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="ForestGreen" /> (RGB: 34, 139, 34, #228B22).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="ForestGreen" /> (RGB: 34, 139, 34, #228B22); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsForestGreen => this == ForestGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Fuchsia (RGB: 255, 0, 255, #FF00FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Fuchsia (RGB: 255, 0, 255, #FF00FF).
    /// </returns>
    public static Color Fuchsia => new(255, 0, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Fuchsia" /> (RGB: 255, 0, 255, #FF00FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Fuchsia" /> (RGB: 255, 0, 255, #FF00FF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsFuchsia => this == Fuchsia;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Gainsboro (RGB: 220, 220, 220, #DCDCDC).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Gainsboro (RGB: 220, 220, 220, #DCDCDC).
    /// </returns>
    public static Color Gainsboro => new(220, 220, 220);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gainsboro" /> (RGB: 220, 220, 220, #DCDCDC).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gainsboro" /> (RGB: 220, 220, 220, #DCDCDC); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGainsboro => this == Gainsboro;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Ghost White (RGB: 248, 248, 255, #F8F8FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Ghost White (RGB: 248, 248, 255, #F8F8FF).
    /// </returns>
    public static Color GhostWhite => new(248, 248, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="GhostWhite" /> (RGB: 248, 248, 255, #F8F8FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="GhostWhite" /> (RGB: 248, 248, 255, #F8F8FF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGhostWhite => this == GhostWhite;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Gold (RGB: 255, 215, 0, #FFD700).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Gold (RGB: 255, 215, 0, #FFD700).
    /// </returns>
    public static Color Gold => new(255, 215, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gold" /> (RGB: 255, 215, 0, #FFD700).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gold" /> (RGB: 255, 215, 0, #FFD700); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGold => this == Gold;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Goldenrod (RGB: 218, 165, 32, #DAA520).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Goldenrod (RGB: 218, 165, 32, #DAA520).
    /// </returns>
    public static Color Goldenrod => new(218, 165, 32);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Goldenrod" /> (RGB: 218, 165, 32, #DAA520).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Goldenrod" /> (RGB: 218, 165, 32, #DAA520); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGoldenrod => this == Goldenrod;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Gray (RGB: 128, 128, 128, #808080).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Gray (RGB: 128, 128, 128, #808080).
    /// </returns>
    public static Color Gray => new(128, 128, 128);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gray" /> (RGB: 128, 128, 128, #808080).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Gray" /> (RGB: 128, 128, 128, #808080); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGray => this == Gray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Green (RGB: 0, 128, 0, #008000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Green (RGB: 0, 128, 0, #008000).
    /// </returns>
    public static Color Green => new(0, 128, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Green" /> (RGB: 0, 128, 0, #008000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Green" /> (RGB: 0, 128, 0, #008000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGreen => this == Green;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Green Yellow (RGB: 173, 255, 47, #ADFF2F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Green Yellow (RGB: 173, 255, 47, #ADFF2F).
    /// </returns>
    public static Color GreenYellow => new(173, 255, 47);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="GreenYellow" /> (RGB: 173, 255, 47, #ADFF2F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="GreenYellow" /> (RGB: 173, 255, 47, #ADFF2F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsGreenYellow => this == GreenYellow;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Honeydew (RGB: 240, 255, 240, #F0FFF0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Honeydew (RGB: 240, 255, 240, #F0FFF0).
    /// </returns>
    public static Color Honeydew => new(240, 255, 240);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Honeydew" /> (RGB: 240, 255, 240, #F0FFF0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Honeydew" /> (RGB: 240, 255, 240, #F0FFF0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsHoneydew => this == Honeydew;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Hot Pink (RGB: 255, 105, 180, #FF69B4).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Hot Pink (RGB: 255, 105, 180, #FF69B4).
    /// </returns>
    public static Color HotPink => new(255, 105, 180);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="HotPink" /> (RGB: 255, 105, 180, #FF69B4).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="HotPink" /> (RGB: 255, 105, 180, #FF69B4); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsHotPink => this == HotPink;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Indian Red (RGB: 205, 92, 92, #CD5C5C).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Indian Red (RGB: 205, 92, 92, #CD5C5C).
    /// </returns>
    public static Color IndianRed => new(205, 92, 92);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="IndianRed" /> (RGB: 205, 92, 92, #CD5C5C).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="IndianRed" /> (RGB: 205, 92, 92, #CD5C5C); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsIndianRed => this == IndianRed;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Indigo (RGB: 75, 0, 130, #4B0082).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Indigo (RGB: 75, 0, 130, #4B0082).
    /// </returns>
    public static Color Indigo => new(75, 0, 130);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Indigo" /> (RGB: 75, 0, 130, #4B0082).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Indigo" /> (RGB: 75, 0, 130, #4B0082); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsIndigo => this == Indigo;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Ivory (RGB: 255, 255, 240, #FFFFF0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Ivory (RGB: 255, 255, 240, #FFFFF0).
    /// </returns>
    public static Color Ivory => new(255, 255, 240);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Ivory" /> (RGB: 255, 255, 240, #FFFFF0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Ivory" /> (RGB: 255, 255, 240, #FFFFF0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsIvory => this == Ivory;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Khaki (RGB: 240, 230, 140, #F0E68C).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Khaki (RGB: 240, 230, 140, #F0E68C).
    /// </returns>
    public static Color Khaki => new(240, 230, 140);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Khaki" /> (RGB: 240, 230, 140, #F0E68C).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Khaki" /> (RGB: 240, 230, 140, #F0E68C); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsKhaki => this == Khaki;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lavender (RGB: 230, 230, 250, #E6E6FA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lavender (RGB: 230, 230, 250, #E6E6FA).
    /// </returns>
    public static Color Lavender => new(230, 230, 250);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Lavender" /> (RGB: 230, 230, 250, #E6E6FA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Lavender" /> (RGB: 230, 230, 250, #E6E6FA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLavender => this == Lavender;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lavender Blush (RGB: 255, 240, 245, #FFF0F5).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lavender Blush (RGB: 255, 240, 245, #FFF0F5).
    /// </returns>
    public static Color LavenderBlush => new(255, 240, 245);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LavenderBlush" /> (RGB: 255, 240, 245, #FFF0F5).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LavenderBlush" /> (RGB: 255, 240, 245, #FFF0F5); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLavenderBlush => this == LavenderBlush;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lawn Green (RGB: 124, 252, 0, #7CFC00).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lawn Green (RGB: 124, 252, 0, #7CFC00).
    /// </returns>
    public static Color LawnGreen => new(124, 252, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LawnGreen" /> (RGB: 124, 252, 0, #7CFC00).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LawnGreen" /> (RGB: 124, 252, 0, #7CFC00); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLawnGreen => this == LawnGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lemon Chiffon (RGB: 255, 250, 205, #FFFACD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lemon Chiffon (RGB: 255, 250, 205, #FFFACD).
    /// </returns>
    public static Color LemonChiffon => new(255, 250, 205);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LemonChiffon" /> (RGB: 255, 250, 205, #FFFACD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LemonChiffon" /> (RGB: 255, 250, 205, #FFFACD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLemonChiffon => this == LemonChiffon;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Blue (RGB: 173, 216, 230, #ADD8E6).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Blue (RGB: 173, 216, 230, #ADD8E6).
    /// </returns>
    public static Color LightBlue => new(173, 216, 230);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightBlue" /> (RGB: 173, 216, 230, #ADD8E6).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightBlue" /> (RGB: 173, 216, 230, #ADD8E6); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightBlue => this == LightBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Coral (RGB: 240, 128, 128, #F08080).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Coral (RGB: 240, 128, 128, #F08080).
    /// </returns>
    public static Color LightCoral => new(240, 128, 128);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightCoral" /> (RGB: 240, 128, 128, #F08080).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightCoral" /> (RGB: 240, 128, 128, #F08080); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightCoral => this == LightCoral;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Cyan (RGB: 224, 255, 255, #E0FFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Cyan (RGB: 224, 255, 255, #E0FFFF).
    /// </returns>
    public static Color LightCyan => new(224, 255, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightCyan" /> (RGB: 224, 255, 255, #E0FFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightCyan" /> (RGB: 224, 255, 255, #E0FFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightCyan => this == LightCyan;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Goldenrod Yellow (RGB: 250, 250, 210, #FAFAD2).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Goldenrod Yellow (RGB: 250, 250, 210, #FAFAD2).
    /// </returns>
    public static Color LightGoldenrodYellow => new(250, 250, 210);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGoldenrodYellow" /> (RGB: 250, 250, 210, #FAFAD2).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGoldenrodYellow" /> (RGB: 250, 250, 210, #FAFAD2); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightGoldenrodYellow => this == LightGoldenrodYellow;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Gray (RGB: 211, 211, 211, #D3D3D3).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Gray (RGB: 211, 211, 211, #D3D3D3).
    /// </returns>
    public static Color LightGray => new(211, 211, 211);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGray" /> (RGB: 211, 211, 211, #D3D3D3).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGray" /> (RGB: 211, 211, 211, #D3D3D3); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightGray => this == LightGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Green (RGB: 144, 238, 144, #90EE90).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Green (RGB: 144, 238, 144, #90EE90).
    /// </returns>
    public static Color LightGreen => new(144, 238, 144);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGreen" /> (RGB: 144, 238, 144, #90EE90).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightGreen" /> (RGB: 144, 238, 144, #90EE90); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightGreen => this == LightGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Pink (RGB: 255, 182, 193, #FFB6C1).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Pink (RGB: 255, 182, 193, #FFB6C1).
    /// </returns>
    public static Color LightPink => new(255, 182, 193);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightPink" /> (RGB: 255, 182, 193, #FFB6C1).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightPink" /> (RGB: 255, 182, 193, #FFB6C1); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightPink => this == LightPink;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Salmon (RGB: 255, 160, 122, #FFA07A).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Salmon (RGB: 255, 160, 122, #FFA07A).
    /// </returns>
    public static Color LightSalmon => new(255, 160, 122);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSalmon" /> (RGB: 255, 160, 122, #FFA07A).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSalmon" /> (RGB: 255, 160, 122, #FFA07A); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightSalmon => this == LightSalmon;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Sea Green (RGB: 32, 178, 170, #20B2AA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Sea Green (RGB: 32, 178, 170, #20B2AA).
    /// </returns>
    public static Color LightSeaGreen => new(32, 178, 170);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSeaGreen" /> (RGB: 32, 178, 170, #20B2AA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSeaGreen" /> (RGB: 32, 178, 170, #20B2AA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightSeaGreen => this == LightSeaGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Sky Blue (RGB: 135, 206, 250, #87CEFA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Sky Blue (RGB: 135, 206, 250, #87CEFA).
    /// </returns>
    public static Color LightSkyBlue => new(135, 206, 250);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSkyBlue" /> (RGB: 135, 206, 250, #87CEFA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSkyBlue" /> (RGB: 135, 206, 250, #87CEFA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightSkyBlue => this == LightSkyBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Slate Gray (RGB: 119, 136, 153, #778899).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Slate Gray (RGB: 119, 136, 153, #778899).
    /// </returns>
    public static Color LightSlateGray => new(119, 136, 153);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSlateGray" /> (RGB: 119, 136, 153, #778899).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSlateGray" /> (RGB: 119, 136, 153, #778899); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightSlateGray => this == LightSlateGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Steel Blue (RGB: 176, 196, 222, #B0C4DE).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Steel Blue (RGB: 176, 196, 222, #B0C4DE).
    /// </returns>
    public static Color LightSteelBlue => new(176, 196, 222);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSteelBlue" /> (RGB: 176, 196, 222, #B0C4DE).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightSteelBlue" /> (RGB: 176, 196, 222, #B0C4DE); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightSteelBlue => this == LightSteelBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Light Yellow (RGB: 255, 255, 224, #FFFFE0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Light Yellow (RGB: 255, 255, 224, #FFFFE0).
    /// </returns>
    public static Color LightYellow => new(255, 255, 224);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightYellow" /> (RGB: 255, 255, 224, #FFFFE0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LightYellow" /> (RGB: 255, 255, 224, #FFFFE0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLightYellow => this == LightYellow;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lime (RGB: 0, 255, 0, #00FF00).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lime (RGB: 0, 255, 0, #00FF00).
    /// </returns>
    public static Color Lime => new(0, 255, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Lime" /> (RGB: 0, 255, 0, #00FF00).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Lime" /> (RGB: 0, 255, 0, #00FF00); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLime => this == Lime;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Lime Green (RGB: 50, 205, 50, #32CD32).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Lime Green (RGB: 50, 205, 50, #32CD32).
    /// </returns>
    public static Color LimeGreen => new(50, 205, 50);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="LimeGreen" /> (RGB: 50, 205, 50, #32CD32).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="LimeGreen" /> (RGB: 50, 205, 50, #32CD32); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLimeGreen => this == LimeGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Linen (RGB: 250, 240, 230, #FAF0E6).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Linen (RGB: 250, 240, 230, #FAF0E6).
    /// </returns>
    public static Color Linen => new(250, 240, 230);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Linen" /> (RGB: 250, 240, 230, #FAF0E6).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Linen" /> (RGB: 250, 240, 230, #FAF0E6); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsLinen => this == Linen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Magenta (RGB: 255, 0, 255, #FF00FF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Magenta (RGB: 255, 0, 255, #FF00FF).
    /// </returns>
    public static Color Magenta => new(255, 0, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Magenta" /> (RGB: 255, 0, 255, #FF00FF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Magenta" /> (RGB: 255, 0, 255, #FF00FF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMagenta => this == Magenta;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Maroon (RGB: 128, 0, 0, #800000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Maroon (RGB: 128, 0, 0, #800000).
    /// </returns>
    public static Color Maroon => new(128, 0, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Maroon" /> (RGB: 128, 0, 0, #800000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Maroon" /> (RGB: 128, 0, 0, #800000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMaroon => this == Maroon;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Aquamarine (RGB: 102, 205, 170, #66CDAA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Aquamarine (RGB: 102, 205, 170, #66CDAA).
    /// </returns>
    public static Color MediumAquamarine => new(102, 205, 170);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumAquamarine" /> (RGB: 102, 205, 170, #66CDAA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumAquamarine" /> (RGB: 102, 205, 170, #66CDAA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumAquamarine => this == MediumAquamarine;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Blue (RGB: 0, 0, 205, #0000CD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Blue (RGB: 0, 0, 205, #0000CD).
    /// </returns>
    public static Color MediumBlue => new(0, 0, 205);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumBlue" /> (RGB: 0, 0, 205, #0000CD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumBlue" /> (RGB: 0, 0, 205, #0000CD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumBlue => this == MediumBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Orchid (RGB: 186, 85, 211, #BA55D3).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Orchid (RGB: 186, 85, 211, #BA55D3).
    /// </returns>
    public static Color MediumOrchid => new(186, 85, 211);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumOrchid" /> (RGB: 186, 85, 211, #BA55D3).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumOrchid" /> (RGB: 186, 85, 211, #BA55D3); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumOrchid => this == MediumOrchid;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Purple (RGB: 147, 112, 219, #9370DB).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Purple (RGB: 147, 112, 219, #9370DB).
    /// </returns>
    public static Color MediumPurple => new(147, 112, 219);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumPurple" /> (RGB: 147, 112, 219, #9370DB).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumPurple" /> (RGB: 147, 112, 219, #9370DB); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumPurple => this == MediumPurple;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Sea Green (RGB: 60, 179, 113, #3CB371).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Sea Green (RGB: 60, 179, 113, #3CB371).
    /// </returns>
    public static Color MediumSeaGreen => new(60, 179, 113);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSeaGreen" /> (RGB: 60, 179, 113, #3CB371).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSeaGreen" /> (RGB: 60, 179, 113, #3CB371); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumSeaGreen => this == MediumSeaGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Slate Blue (RGB: 123, 104, 238, #7B68EE).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Slate Blue (RGB: 123, 104, 238, #7B68EE).
    /// </returns>
    public static Color MediumSlateBlue => new(123, 104, 238);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSlateBlue" /> (RGB: 123, 104, 238, #7B68EE).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSlateBlue" /> (RGB: 123, 104, 238, #7B68EE); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumSlateBlue => this == MediumSlateBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Spring Green (RGB: 0, 250, 154, #00FA9A).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Spring Green (RGB: 0, 250, 154, #00FA9A).
    /// </returns>
    public static Color MediumSpringGreen => new(0, 250, 154);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSpringGreen" /> (RGB: 0, 250, 154, #00FA9A).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumSpringGreen" /> (RGB: 0, 250, 154, #00FA9A); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumSpringGreen => this == MediumSpringGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Turquoise (RGB: 72, 209, 204, #48D1CC).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Turquoise (RGB: 72, 209, 204, #48D1CC).
    /// </returns>
    public static Color MediumTurquoise => new(72, 209, 204);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumTurquoise" /> (RGB: 72, 209, 204, #48D1CC).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumTurquoise" /> (RGB: 72, 209, 204, #48D1CC); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumTurquoise => this == MediumTurquoise;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Medium Violet Red (RGB: 199, 21, 133, #C71585).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Medium Violet Red (RGB: 199, 21, 133, #C71585).
    /// </returns>
    public static Color MediumVioletRed => new(199, 21, 133);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumVioletRed" /> (RGB: 199, 21, 133, #C71585).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MediumVioletRed" /> (RGB: 199, 21, 133, #C71585); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMediumVioletRed => this == MediumVioletRed;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Midnight Blue (RGB: 25, 25, 112, #191970).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Midnight Blue (RGB: 25, 25, 112, #191970).
    /// </returns>
    public static Color MidnightBlue => new(25, 25, 112);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MidnightBlue" /> (RGB: 25, 25, 112, #191970).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MidnightBlue" /> (RGB: 25, 25, 112, #191970); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMidnightBlue => this == MidnightBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Mint Cream (RGB: 245, 255, 250, #F5FFFA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Mint Cream (RGB: 245, 255, 250, #F5FFFA).
    /// </returns>
    public static Color MintCream => new(245, 255, 250);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MintCream" /> (RGB: 245, 255, 250, #F5FFFA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MintCream" /> (RGB: 245, 255, 250, #F5FFFA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMintCream => this == MintCream;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Misty Rose (RGB: 255, 228, 225, #FFE4E1).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Misty Rose (RGB: 255, 228, 225, #FFE4E1).
    /// </returns>
    public static Color MistyRose => new(255, 228, 225);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="MistyRose" /> (RGB: 255, 228, 225, #FFE4E1).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="MistyRose" /> (RGB: 255, 228, 225, #FFE4E1); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMistyRose => this == MistyRose;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Moccasin (RGB: 255, 228, 181, #FFE4B5).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Moccasin (RGB: 255, 228, 181, #FFE4B5).
    /// </returns>
    public static Color Moccasin => new(255, 228, 181);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Moccasin" /> (RGB: 255, 228, 181, #FFE4B5).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Moccasin" /> (RGB: 255, 228, 181, #FFE4B5); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsMoccasin => this == Moccasin;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Navajo White (RGB: 255, 222, 173, #FFDEAD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Navajo White (RGB: 255, 222, 173, #FFDEAD).
    /// </returns>
    public static Color NavajoWhite => new(255, 222, 173);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="NavajoWhite" /> (RGB: 255, 222, 173, #FFDEAD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="NavajoWhite" /> (RGB: 255, 222, 173, #FFDEAD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsNavajoWhite => this == NavajoWhite;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Navy (RGB: 0, 0, 128, #000080).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Navy (RGB: 0, 0, 128, #000080).
    /// </returns>
    public static Color Navy => new(0, 0, 128);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Navy" /> (RGB: 0, 0, 128, #000080).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Navy" /> (RGB: 0, 0, 128, #000080); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsNavy => this == Navy;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Old Lace (RGB: 253, 245, 230, #FDF5E6).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Old Lace (RGB: 253, 245, 230, #FDF5E6).
    /// </returns>
    public static Color OldLace => new(253, 245, 230);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="OldLace" /> (RGB: 253, 245, 230, #FDF5E6).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="OldLace" /> (RGB: 253, 245, 230, #FDF5E6); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOldLace => this == OldLace;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Olive (RGB: 128, 128, 0, #808000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Olive (RGB: 128, 128, 0, #808000).
    /// </returns>
    public static Color Olive => new(128, 128, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Olive" /> (RGB: 128, 128, 0, #808000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Olive" /> (RGB: 128, 128, 0, #808000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOlive => this == Olive;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Olive Drab (RGB: 107, 142, 35, #6B8E23).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Olive Drab (RGB: 107, 142, 35, #6B8E23).
    /// </returns>
    public static Color OliveDrab => new(107, 142, 35);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="OliveDrab" /> (RGB: 107, 142, 35, #6B8E23).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="OliveDrab" /> (RGB: 107, 142, 35, #6B8E23); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOliveDrab => this == OliveDrab;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Orange (RGB: 255, 165, 0, #FFA500).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Orange (RGB: 255, 165, 0, #FFA500).
    /// </returns>
    public static Color Orange => new(255, 165, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Orange" /> (RGB: 255, 165, 0, #FFA500).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Orange" /> (RGB: 255, 165, 0, #FFA500); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOrange => this == Orange;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Orange Red (RGB: 255, 69, 0, #FF4500).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Orange Red (RGB: 255, 69, 0, #FF4500).
    /// </returns>
    public static Color OrangeRed => new(255, 69, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="OrangeRed" /> (RGB: 255, 69, 0, #FF4500).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="OrangeRed" /> (RGB: 255, 69, 0, #FF4500); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOrangeRed => this == OrangeRed;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Orchid (RGB: 218, 112, 214, #DA70D6).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Orchid (RGB: 218, 112, 214, #DA70D6).
    /// </returns>
    public static Color Orchid => new(218, 112, 214);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Orchid" /> (RGB: 218, 112, 214, #DA70D6).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Orchid" /> (RGB: 218, 112, 214, #DA70D6); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsOrchid => this == Orchid;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// pale Goldenrod (RGB: 238, 232, 170, #EEE8AA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// pale Goldenrod (RGB: 238, 232, 170, #EEE8AA).
    /// </returns>
    public static Color PaleGoldenrod => new(238, 232, 170);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleGoldenrod" /> (RGB: 238, 232, 170, #EEE8AA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleGoldenrod" /> (RGB: 238, 232, 170, #EEE8AA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPaleGoldenrod => this == PaleGoldenrod;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// pale Green (RGB: 152, 251, 152, #98FB98).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// pale Green (RGB: 152, 251, 152, #98FB98).
    /// </returns>
    public static Color PaleGreen => new(152, 251, 152);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleGreen" /> (RGB: 152, 251, 152, #98FB98).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleGreen" /> (RGB: 152, 251, 152, #98FB98); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPaleGreen => this == PaleGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// pale Turquoise (RGB: 175, 238, 238, #AFEEEE).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// pale Turquoise (RGB: 175, 238, 238, #AFEEEE).
    /// </returns>
    public static Color PaleTurquoise => new(175, 238, 238);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleTurquoise" /> (RGB: 175, 238, 238, #AFEEEE).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleTurquoise" /> (RGB: 175, 238, 238, #AFEEEE); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPaleTurquoise => this == PaleTurquoise;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// pale Violet Red (RGB: 219, 112, 147, #DB7093).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// pale Violet Red (RGB: 219, 112, 147, #DB7093).
    /// </returns>
    public static Color PaleVioletRed => new(219, 112, 147);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleVioletRed" /> (RGB: 219, 112, 147, #DB7093).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PaleVioletRed" /> (RGB: 219, 112, 147, #DB7093); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPaleVioletRed => this == PaleVioletRed;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// papaya Whip (RGB: 255, 239, 213, #FFEFD5).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// papaya Whip (RGB: 255, 239, 213, #FFEFD5).
    /// </returns>
    public static Color PapayaWhip => new(255, 239, 213);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PapayaWhip" /> (RGB: 255, 239, 213, #FFEFD5).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PapayaWhip" /> (RGB: 255, 239, 213, #FFEFD5); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPapayaWhip => this == PapayaWhip;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// peach Puff (RGB: 255, 218, 185, #FFDAB9).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// peach Puff (RGB: 255, 218, 185, #FFDAB9).
    /// </returns>
    public static Color PeachPuff => new(255, 218, 185);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PeachPuff" /> (RGB: 255, 218, 185, #FFDAB9).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PeachPuff" /> (RGB: 255, 218, 185, #FFDAB9); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPeachPuff => this == PeachPuff;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// peru (RGB: 205, 133, 63, #CD853F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// peru (RGB: 205, 133, 63, #CD853F).
    /// </returns>
    public static Color Peru => new(205, 133, 63);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Peru" /> (RGB: 205, 133, 63, #CD853F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Peru" /> (RGB: 205, 133, 63, #CD853F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPeru => this == Peru;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// pink (RGB: 255, 192, 203, #FFC0CB).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// pink (RGB: 255, 192, 203, #FFC0CB).
    /// </returns>
    public static Color Pink => new(255, 192, 203);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Pink" /> (RGB: 255, 192, 203, #FFC0CB).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Pink" /> (RGB: 255, 192, 203, #FFC0CB); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPink => this == Pink;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// plum (RGB: 221, 160, 221, #DDA0DD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// plum (RGB: 221, 160, 221, #DDA0DD).
    /// </returns>
    public static Color Plum => new(221, 160, 221);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Plum" /> (RGB: 221, 160, 221, #DDA0DD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Plum" /> (RGB: 221, 160, 221, #DDA0DD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPlum => this == Plum;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// powder Blue (RGB: 176, 224, 230, #B0E0E6).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// powder Blue (RGB: 176, 224, 230, #B0E0E6).
    /// </returns>
    public static Color PowderBlue => new(176, 224, 230);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="PowderBlue" /> (RGB: 176, 224, 230, #B0E0E6).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="PowderBlue" /> (RGB: 176, 224, 230, #B0E0E6); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPowderBlue => this == PowderBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    /// purple (RGB: 128, 0, 128, #800080).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    /// purple (RGB: 128, 0, 128, #800080).
    /// </returns>
    public static Color Purple => new(128, 0, 128);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Purple" /> (RGB: 128, 0, 128, #800080).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Purple" /> (RGB: 128, 0, 128, #800080); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsPurple => this == Purple;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Red (RGB: 255, 0, 0, #FF0000).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Red (RGB: 255, 0, 0, #FF0000).
    /// </returns>
    public static Color Red => new(255, 0, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Red" /> (RGB: 255, 0, 0, #FF0000).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Red" /> (RGB: 255, 0, 0, #FF0000); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsRed => this == Red;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Rosy Brown (RGB: 188, 143, 143, #BC8F8F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Rosy Brown (RGB: 188, 143, 143, #BC8F8F).
    /// </returns>
    public static Color RosyBrown => new(188, 143, 143);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="RosyBrown" /> (RGB: 188, 143, 143, #BC8F8F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="RosyBrown" /> (RGB: 188, 143, 143, #BC8F8F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsRosyBrown => this == RosyBrown;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Royal Blue (RGB: 65, 105, 225, #4169E1).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Royal Blue (RGB: 65, 105, 225, #4169E1).
    /// </returns>
    public static Color RoyalBlue => new(65, 105, 225);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="RoyalBlue" /> (RGB: 65, 105, 225, #4169E1).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="RoyalBlue" /> (RGB: 65, 105, 225, #4169E1); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsRoyalBlue => this == RoyalBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Saddle Brown (RGB: 139, 69, 19, #8B4513).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Saddle Brown (RGB: 139, 69, 19, #8B4513).
    /// </returns>
    public static Color SaddleBrown => new(139, 69, 19);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SaddleBrown" /> (RGB: 139, 69, 19, #8B4513).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SaddleBrown" /> (RGB: 139, 69, 19, #8B4513); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSaddleBrown => this == SaddleBrown;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Salmon (RGB: 250, 128, 114, #FA8072).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Salmon (RGB: 250, 128, 114, #FA8072).
    /// </returns>
    public static Color Salmon => new(250, 128, 114);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Salmon" /> (RGB: 250, 128, 114, #FA8072).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Salmon" /> (RGB: 250, 128, 114, #FA8072); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSalmon => this == Salmon;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Sandy Brown (RGB: 244, 164, 96, #F4A460).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Sandy Brown (RGB: 244, 164, 96, #F4A460).
    /// </returns>
    public static Color SandyBrown => new(244, 164, 96);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SandyBrown" /> (RGB: 244, 164, 96, #F4A460).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SandyBrown" /> (RGB: 244, 164, 96, #F4A460); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSandyBrown => this == SandyBrown;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Sea Green (RGB: 46, 139, 87, #2E8B57).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Sea Green (RGB: 46, 139, 87, #2E8B57).
    /// </returns>
    public static Color SeaGreen => new(46, 139, 87);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SeaGreen" /> (RGB: 46, 139, 87, #2E8B57).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SeaGreen" /> (RGB: 46, 139, 87, #2E8B57); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSeaGreen => this == SeaGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     SeaShell (RGB: 255, 245, 238, #FFF5EE).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     SeaShell (RGB: 255, 245, 238, #FFF5EE).
    /// </returns>
    public static Color SeaShell => new(255, 245, 238);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SeaShell" /> (RGB: 255, 245, 238, #FFF5EE).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SeaShell" /> (RGB: 255, 245, 238, #FFF5EE); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSeaShell => this == SeaShell;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Sienna (RGB: 160, 82, 45, #A0522D).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Sienna (RGB: 160, 82, 45, #A0522D).
    /// </returns>
    public static Color Sienna => new(160, 82, 45);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Sienna" /> (RGB: 160, 82, 45, #A0522D).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Sienna" /> (RGB: 160, 82, 45, #A0522D); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSienna => this == Sienna;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Silver (RGB: 192, 192, 192, #C0C0C0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Silver (RGB: 192, 192, 192, #C0C0C0).
    /// </returns>
    public static Color Silver => new(192, 192, 192);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Silver" /> (RGB: 192, 192, 192, #C0C0C0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Silver" /> (RGB: 192, 192, 192, #C0C0C0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSilver => this == Silver;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Sky Blue (RGB: 135, 206, 235, #87CEEB).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Sky Blue (RGB: 135, 206, 235, #87CEEB).
    /// </returns>
    public static Color SkyBlue => new(135, 206, 235);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SkyBlue" /> (RGB: 135, 206, 235, #87CEEB).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SkyBlue" /> (RGB: 135, 206, 235, #87CEEB); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSkyBlue => this == SkyBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Slate Blue (RGB: 106, 90, 205, #6A5ACD).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Slate Blue (RGB: 106, 90, 205, #6A5ACD).
    /// </returns>
    public static Color SlateBlue => new(106, 90, 205);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SlateBlue" /> (RGB: 106, 90, 205, #6A5ACD).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SlateBlue" /> (RGB: 106, 90, 205, #6A5ACD); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSlateBlue => this == SlateBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Slate Gray (RGB: 112, 128, 144, #708090).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Slate Gray (RGB: 112, 128, 144, #708090).
    /// </returns>
    public static Color SlateGray => new(112, 128, 144);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SlateGray" /> (RGB: 112, 128, 144, #708090).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SlateGray" /> (RGB: 112, 128, 144, #708090); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSlateGray => this == SlateGray;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Snow (RGB: 255, 250, 250, #FFFAFA).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Snow (RGB: 255, 250, 250, #FFFAFA).
    /// </returns>
    public static Color Snow => new(255, 250, 250);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Snow" /> (RGB: 255, 250, 250, #FFFAFA).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Snow" /> (RGB: 255, 250, 250, #FFFAFA); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSnow => this == Snow;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Spring Green (RGB: 0, 255, 127, #00FF7F).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Spring Green (RGB: 0, 255, 127, #00FF7F).
    /// </returns>
    public static Color SpringGreen => new(0, 255, 127);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SpringGreen" /> (RGB: 0, 255, 127, #00FF7F).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SpringGreen" /> (RGB: 0, 255, 127, #00FF7F); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSpringGreen => this == SpringGreen;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Steel Blue (RGB: 70, 130, 180, #4682B4).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Steel Blue (RGB: 70, 130, 180, #4682B4).
    /// </returns>
    public static Color SteelBlue => new(70, 130, 180);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="SteelBlue" /> (RGB: 70, 130, 180, #4682B4).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="SteelBlue" /> (RGB: 70, 130, 180, #4682B4); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsSteelBlue => this == SteelBlue;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Tan (RGB: 210, 180, 140, #D2B48C).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Tan (RGB: 210, 180, 140, #D2B48C).
    /// </returns>
    public static Color Tan => new(210, 180, 140);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Tan" /> (RGB: 210, 180, 140, #D2B48C).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Tan" /> (RGB: 210, 180, 140, #D2B48C); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsTan => this == Tan;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Teal (RGB: 0, 128, 128, #008080).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Teal (RGB: 0, 128, 128, #008080).
    /// </returns>
    public static Color Teal => new(0, 128, 128);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Teal" /> (RGB: 0, 128, 128, #008080).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Teal" /> (RGB: 0, 128, 128, #008080); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsTeal => this == Teal;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Thistle (RGB: 216, 191, 216, #D8BFD8).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Thistle (RGB: 216, 191, 216, #D8BFD8).
    /// </returns>
    public static Color Thistle => new(216, 191, 216);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Thistle" /> (RGB: 216, 191, 216, #D8BFD8).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Thistle" /> (RGB: 216, 191, 216, #D8BFD8); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsThistle => this == Thistle;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Tomato (RGB: 255, 99, 71, #FF6347).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Tomato (RGB: 255, 99, 71, #FF6347).
    /// </returns>
    public static Color Tomato => new(255, 99, 71);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Tomato" /> (RGB: 255, 99, 71, #FF6347).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Tomato" /> (RGB: 255, 99, 71, #FF6347); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsTomato => this == Tomato;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Turquoise (RGB: 64, 224, 208, #40E0D0).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Turquoise (RGB: 64, 224, 208, #40E0D0).
    /// </returns>
    public static Color Turquoise => new(64, 224, 208);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Turquoise" /> (RGB: 64, 224, 208, #40E0D0).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Turquoise" /> (RGB: 64, 224, 208, #40E0D0); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsTurquoise => this == Turquoise;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Violet (RGB: 238, 130, 238, #EE82EE).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Violet (RGB: 238, 130, 238, #EE82EE).
    /// </returns>
    public static Color Violet => new(238, 130, 238);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Violet" /> (RGB: 238, 130, 238, #EE82EE).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Violet" /> (RGB: 238, 130, 238, #EE82EE); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsViolet => this == Violet;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Wheat (RGB: 245, 222, 179, #F5DEB3).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Wheat (RGB: 245, 222, 179, #F5DEB3).
    /// </returns>
    public static Color Wheat => new(245, 222, 179);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Wheat" /> (RGB: 245, 222, 179, #F5DEB3).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Wheat" /> (RGB: 245, 222, 179, #F5DEB3); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsWheat => this == Wheat;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     White (RGB: 255, 255, 255, #FFFFFF).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     White (RGB: 255, 255, 255, #FFFFFF).
    /// </returns>
    public static Color White => new(255, 255, 255);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="White" /> (RGB: 255, 255, 255, #FFFFFF).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="White" /> (RGB: 255, 255, 255, #FFFFFF); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsWhite => this == White;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     White Smoke (RGB: 245, 245, 245, #F5F5F5).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     White Smoke (RGB: 245, 245, 245, #F5F5F5).
    /// </returns>
    public static Color WhiteSmoke => new(245, 245, 245);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="WhiteSmoke" /> (RGB: 245, 245, 245, #F5F5F5).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="WhiteSmoke" /> (RGB: 245, 245, 245, #F5F5F5); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsWhiteSmoke => this == WhiteSmoke;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Yellow (RGB: 255, 255, 0, #FFFF00).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Yellow (RGB: 255, 255, 0, #FFFF00).
    /// </returns>
    public static Color Yellow => new(255, 255, 0);


    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="Yellow" /> (RGB: 255, 255, 0, #FFFF00).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="Yellow" /> (RGB: 255, 255, 0, #FFFF00); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsYellow => this == Yellow;

    /// <summary>
    ///     Get a <see cref="Color" /> instance representing the color
    ///     Yellow Green (RGB: 154, 205, 50, #9ACD32).
    /// </summary>
    /// <returns>
    ///     A <see cref="Color" /> instance representing the color
    ///     Yellow Green (RGB: 154, 205, 50, #9ACD32).
    /// </returns>
    public static Color YellowGreen => new(154, 205, 50);

    /// <summary>
    ///     Determines whether this <see cref="Color" /> instance is equal to 
    ///     <see cref="YellowGreen" /> (RGB: 154, 205, 50, #9ACD32).
    /// </summary>
    /// <returns>
    ///     <see langword="true" /> if this <see cref="Color" /> instance is equal to 
    ///     <see cref="YellowGreen" /> (RGB: 154, 205, 50, #9ACD32); 
    ///     otherwise, <see langword="false" />.
    /// </returns>
    public bool IsYellowGreen => this == YellowGreen;
}