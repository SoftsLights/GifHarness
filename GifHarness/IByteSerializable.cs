namespace GifHarness;

/// <summary>
///     Interface for serializing and deserializing objects to and from bytes.
/// </summary>
/// <typeparam name="T">
///     The type of object to serialize and deserialize.
/// </typeparam>
public interface IByteSerializable<T>
{
    /// <summary>
    ///     Reads a byte array and returns an object of type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="data">
    ///     The byte array to read.
    /// </param>
    /// <returns>
    ///     An object of type <typeparamref name="T"/>.
    /// </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown if the byte array is invalid.
    /// </exception>
    public static abstract T ReadBytes(byte[] data);

    /// <summary>
    ///     Writes an object of type <typeparamref name="T"/> to a byte array.
    /// </summary>
    /// <param name="obj">
    ///     The object to write to a byte array.
    /// </param>
    /// <returns>
    ///     A byte array representing the object.
    /// </returns>
    /// <remarks>
    ///     <para>
    ///         The byte array should be able to be read back into an object
    ///         of type <typeparamref name="T"/>
    ///         using the <see cref="ReadBytes"/> method.
    ///     </para>
    ///     <para>
    ///         The read back is not guaranteed to be the same object as the one
    ///         written nor is it guaranteed to be equal to the original object.
    ///     </para>
    /// </remarks>
    public static abstract byte[] WriteBytes(T obj);
}