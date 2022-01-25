using System.Reflection;

namespace Meraki.Api;
/// <summary>
/// A custom IHttpContentSerializer based on NewtonsoftJsonContentSerializer
/// to handle retries after missing members are observed
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

	private async Task<T?> LogWarningOnErrorAndContinueFromHttpContentAsync<T>(HttpContent content, CancellationToken _)
	{
		// This code has to read the content all at once into a stream
		// as we might re-use it in the second DeserializeObject call
		var sourceJson = await content.ReadAsStringAsync().ConfigureAwait(false);
		try
		{
			return JsonConvert.DeserializeObject<T>(sourceJson, _jsonSerializerSettingsWithError);
		}
		catch (JsonSerializationException ex)
		{
			_logger.LogWarning(ex, ex.Message);

			return JsonConvert.DeserializeObject<T>(sourceJson, _jsonSerializerSettingsWithIgnore);
		}
	}

	public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
		=> _serializerIgnore.GetFieldNameForProperty(propertyInfo);

	public HttpContent ToHttpContent<T>(T item)
		=> _serializerIgnore.ToHttpContent<T>(item);
}
