namespace Meraki.Api.Data;

/// <summary>
/// Reads and writes a struct that wraps a string as a plain JSON string,
/// so any value the API returns is kept and written back unchanged
/// </summary>
/// <typeparam name="T">The wrapping struct</typeparam>
internal abstract class StringValueJsonConverter<T> : JsonConverter where T : struct
{
	/// <summary>
	/// Creates the struct from its string value
	/// </summary>
	/// <param name="value">The string value</param>
	protected abstract T Create(string value);

	/// <summary>
	/// Gets the string value of the struct, or null for the default instance
	/// </summary>
	/// <param name="value">The struct</param>
	protected abstract string? GetValue(T value);

	/// <inheritdoc />
	public override bool CanConvert(Type objectType)
		=> objectType == typeof(T) || objectType == typeof(T?);

	/// <inheritdoc />
	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		=> reader.TokenType switch
		{
			JsonToken.Null => objectType == typeof(T?) ? null : default(T),
			JsonToken.String => Create((string)reader.Value!),
			_ => throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing {typeof(T).Name}. Path '{reader.Path}'.")
		};

	/// <inheritdoc />
	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		var stringValue = value is T typedValue ? GetValue(typedValue) : null;
		if (stringValue is null)
		{
			writer.WriteNull();
			return;
		}

		writer.WriteValue(stringValue);
	}
}
