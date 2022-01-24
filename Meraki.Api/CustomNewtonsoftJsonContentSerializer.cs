using System.IO;
using System.Reflection;

namespace Meraki.Api;
/// <summary>
/// A custom NewtonsoftJsonContentSerializer to handle retries after missing members are observed
/// </summary>
public class CustomNewtonsoftJsonContentSerializer : IHttpContentSerializer
{
	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
	private readonly JsonSerializerSettings _jsonSerializerSettingsWithIgnore;
	private readonly JsonSerializerSettings _jsonSerializerSettingsWithError;
	private readonly NewtonsoftJsonContentSerializer _serializerIgnore;
	private readonly NewtonsoftJsonContentSerializer _serializerError;

	public CustomNewtonsoftJsonContentSerializer(MerakiClientOptions options, ILogger logger)
	{
		_options = options;
		_logger = logger;
		_jsonSerializerSettingsWithIgnore = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Ignore,
			Converters = new List<JsonConverter> { new StringEnumConverter() }
		};
		_jsonSerializerSettingsWithError = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Error,
			Converters = new List<JsonConverter> { new StringEnumConverter() }
		};

		_serializerIgnore = new NewtonsoftJsonContentSerializer(_jsonSerializerSettingsWithIgnore);

		_serializerError = new NewtonsoftJsonContentSerializer(_jsonSerializerSettingsWithError);
	}

	public async Task<T?> FromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken = default)
		=> _options.JsonMissingMemberHandling switch
		{
			JsonMissingMemberHandling.Ignore => await _serializerIgnore.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			JsonMissingMemberHandling.ThrowOnError => await _serializerError.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			JsonMissingMemberHandling.LogWarningOnErrorAndContinue => await LogWarningOnErrorAndContinueFromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			_ => throw new NotSupportedException()
		};

	private async Task<T?> LogWarningOnErrorAndContinueFromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken)
	{
		using var stream = await content.ReadAsStreamAsync().ConfigureAwait(false);
		using var reader = new StreamReader(stream);
		try
		{
			var serializer = JsonSerializer.Create(_jsonSerializerSettingsWithError);
			using var jsonTextReader = new JsonTextReader(reader);

			return serializer.Deserialize<T>(jsonTextReader);
		}
		catch (JsonSerializationException ex)
		{
			_logger.LogWarning(ex, ex.Message);

			// Reset the stream
			stream.Seek(0, SeekOrigin.Begin);

			var serializer = JsonSerializer.Create(_jsonSerializerSettingsWithIgnore);
			using var jsonTextReader = new JsonTextReader(reader);

			return serializer.Deserialize<T>(jsonTextReader);
		}
	}

	public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
		=> _serializerIgnore.GetFieldNameForProperty(propertyInfo);

	public HttpContent ToHttpContent<T>(T item)
		=> _serializerIgnore.ToHttpContent<T>(item);
}
