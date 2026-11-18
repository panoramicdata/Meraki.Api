using Newtonsoft.Json.Serialization;

namespace Meraki.Api;

/// <summary>
/// Reads enums as <see cref="StringEnumConverter"/> does, except that an unknown string follows
/// <see cref="MerakiClientOptions.UnknownEnumValueHandling"/>
/// </summary>
internal sealed class TolerantStringEnumConverter(MerakiClientOptions options, ILogger logger) : StringEnumConverter
{
	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		if (reader.TokenType != JsonToken.String || options.UnknownEnumValueHandling != UnknownEnumValueHandling.UseDefault)
		{
			return base.ReadJson(reader, objectType, existingValue, serializer);
		}

		var rawValue = (string?)reader.Value;
		var path = reader.Path;
		try
		{
			return base.ReadJson(reader, objectType, existingValue, serializer);
		}
		catch (JsonSerializationException)
		{
			var underlying = Nullable.GetUnderlyingType(objectType);
			logger.LogWarning("Unknown enum value '{Value}' for {EnumType} at {Path}; using the default", rawValue, (underlying ?? objectType).Name, path);
			return underlying is not null ? null : Enum.GetValues(objectType).GetValue(0);
		}
	}
}

/// <summary>
/// Installs <see cref="TolerantStringEnumConverter"/> over the converter attribute each enum declares
/// </summary>
internal sealed class TolerantEnumContractResolver(MerakiClientOptions options, ILogger logger) : DefaultContractResolver
{
	private readonly TolerantStringEnumConverter _converter = new(options, logger);

	protected override JsonContract CreateContract(Type objectType)
	{
		var contract = base.CreateContract(objectType);
		if ((Nullable.GetUnderlyingType(objectType) ?? objectType).IsEnum)
		{
			contract.Converter = _converter;
		}

		return contract;
	}
}
