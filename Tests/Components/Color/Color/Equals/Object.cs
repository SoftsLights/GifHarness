// ReSharper disable SuspiciousTypeConversion.Global

namespace Tests.Components.Color.Color.Equals;

public class Object
{
    [Fact]
    public void ColorEasyEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.True(color.Equals(otherColor as object));
    }

    [Fact]
    public void ColorNormalEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.True(color.Equals(otherColor as object));
    }

    [Fact]
    public void ColorRandomEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.True(color.Equals(otherColor as object));
    }

    [Fact]
    public void ColorEasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed + 1,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(otherColor as object));
    }

    [Fact]
    public void ColorNormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen + 1, expectedBlue);

        Assert.False(color.Equals(otherColor as object));
    }

    [Fact]
    public void ColorRandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color otherColor = new(
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.False(color.Equals(otherColor as object));
    }

    [Fact]
    public void SystemDrawingColorEasyEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(color.Equals(drawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorNormalEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(color.Equals(drawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorRandomEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        System.Drawing.Color drawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, expectedBlue);

        GifHarness.Components.Colors.Color color = new(drawingColor);

        Assert.True(color.Equals(drawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorEasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed + 1,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorNormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen + 1, expectedBlue);

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorRandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorEasyNotEqualAlpha()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;
        const byte expectedAlpha = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha + 1,
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorNormalNotEqualAlpha()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;
        const byte expectedAlpha = 255;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha - 1,
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void SystemDrawingColorRandomNotEqualAlpha()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);
        byte expectedAlpha = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        System.Drawing.Color otherDrawingColor = System.Drawing.Color.FromArgb(
            expectedAlpha,
            expectedRed,
            expectedGreen, (byte)(expectedBlue + 1));

        Assert.False(color.Equals(otherDrawingColor as object));
    }

    [Fact]
    public void ByteSerializationEasyEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationNormalEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationRandomEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationEasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        bytes[0]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationNormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        bytes[1]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationRandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = GifHarness.Components.Colors.Color.WriteBytes(color);

        bytes[2]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationEasyInstanceEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationNormalInstanceEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationRandomInstanceEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.True(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationEasyInstanceNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        bytes[0]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationNormalInstanceNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        bytes[1]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationRandomInstanceNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        bytes[2]++;

        Assert.False(color.Equals(bytes));
    }

    [Fact]
    public void ByteSerializationEasyInstanceNotEqualLength()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.False(color.Equals(bytes[..^1]));
    }

    [Fact]
    public void ByteSerializationNormalInstanceNotEqualLength()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.False(color.Equals(bytes[..^1]));
    }

    [Fact]
    public void ByteSerializationRandomInstanceNotEqualLength()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        byte[] bytes = color.WriteBytes();

        Assert.False(color.Equals(bytes[..^1]));
    }

    [Fact]
    public void ByteSerializationEasyInstanceNotEqualLengthZero()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(Array.Empty<byte>()));
    }

    [Fact]
    public void ByteSerializationNormalInstanceNotEqualLengthZero()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(Array.Empty<byte>()));
    }

    [Fact]
    public void ByteSerializationRandomInstanceNotEqualLengthZero()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 255);

        GifHarness.Components.Colors.Color color = new(expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(Array.Empty<byte>()));
    }

    [Fact]
    public void RandomObjectEasyNotEqual()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        const int randomInt = 0;
        const char randomChar = 'a';

        Assert.False(color.Equals(randomInt));
        Assert.False(color.Equals(randomChar));
    }

    [Fact]
    public void RandomObjectNormalNotEqual()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        const int randomInt = 0;
        const char randomChar = 'a';

        Assert.False(color.Equals(randomInt));
        Assert.False(color.Equals(randomChar));
    }

    [Fact]
    public void RandomObjectRandomNotEqual()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        const int randomInt = 0;
        const char randomChar = 'a';

        Assert.False(color.Equals(randomInt));
        Assert.False(color.Equals(randomChar));
    }

    [Fact]
    public void RandomObjectEasyNotEqualNull()
    {
        const byte expectedRed = 0;
        const byte expectedGreen = 0;
        const byte expectedBlue = 0;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(null));
    }

    [Fact]
    public void RandomObjectNormalNotEqualNull()
    {
        const byte expectedRed = 25;
        const byte expectedGreen = 176;
        const byte expectedBlue = 243;

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(null));
    }

    [Fact]
    public void RandomObjectRandomNotEqualNull()
    {
        Random random = new();

        byte expectedRed = (byte)random.Next(0, 256);
        byte expectedGreen = (byte)random.Next(0, 256);
        byte expectedBlue = (byte)random.Next(0, 256);

        GifHarness.Components.Colors.Color color = new(
            expectedRed,
            expectedGreen, expectedBlue);

        Assert.False(color.Equals(null));
    }
}