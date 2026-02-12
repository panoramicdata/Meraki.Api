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

	/// <summary>
	/// Initializes a new instance of the CustomNewtonsoftJsonContentSerializer class
	/// </summary>
	/// <param name="options">The Meraki client options</param>
	/// <param name="logger">The logger instance</param>
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
			Converters = [new StringEnumConverter()]
		};
		_jsonSerializerSettingsWithError = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Error,
			Converters = [new StringEnumConverter()]
		};

		_serializerIgnore = new NewtonsoftJsonContentSerializer(_jsonSerializerSettingsWithIgnore);
	}

	/// <summary>
	/// Deserializes an object from HTTP content
	/// </summary>
	/// <typeparam name="T">The type to deserialize to</typeparam>
	/// <param name="content">The HTTP content to deserialize</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <returns>The deserialized object</returns>
	public async Task<T?> FromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken = default)
		=> _options.JsonMissingMemberHandling switch
		{
			JsonMissingMemberHandling.Ignore => await _serializerIgnore.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			JsonMissingMemberHandling.ThrowOnError => await LogOnErrorAndThrowFromHttpContentAsync<T>(content).ConfigureAwait(false),
			JsonMissingMemberHandling.LogWarningOnErrorAndContinue => await LogWarningOnErrorAndContinueFromHttpContentAsync<T>(content).ConfigureAwait(false),
			_ => throw new NotSupportedException()
		};

	private async Task<T?> LogWarningOnErrorAndContinueFromHttpContentAsync<T>(HttpContent content)
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
			_logger.LogWarning(ex, "JsonSerializationException: {Message}", ex.Message);

			if (_options.JsonMissingMemberResponseLogLevel != LogLevel.None)
			{
#pragma warning disable CA1873 // Avoid potentially expensive logging
				_logger.Log(_options.JsonMissingMemberResponseLogLevel, "Missing Member Response JSON:\n{SourceJson}", sourceJson);
#pragma warning restore CA1873 // Avoid potentially expensive logging
			}

			// Execute the action if one was provided
			_options.JsonMissingMemberAction?.Invoke(typeof(T), ex, sourceJson);

			return JsonConvert.DeserializeObject<T>(sourceJson, _jsonSerializerSettingsWithIgnore);
		}
		catch (JsonReaderException ex)
		{
#pragma warning disable S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			_logger.LogWarning("JsonReaderException: {Message} - Invalid JSON: {Json}", ex.Message, sourceJson);
#pragma warning restore S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			throw;
		}
	}

	private async Task<T?> LogOnErrorAndThrowFromHttpContentAsync<T>(HttpContent content)
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
			if (_options.JsonMissingMemberResponseLogLevel != LogLevel.None)
			{
#pragma warning disable CA1873 // Avoid potentially expensive logging
				_logger.Log(_options.JsonMissingMemberResponseLogLevel, "Missing Member Response JSON:\n{SourceJson}", sourceJson);
#pragma warning restore CA1873 // Avoid potentially expensive logging
			}

			// Execute the action if one was provided
			_options.JsonMissingMemberAction?.Invoke(typeof(T), ex, sourceJson);

			throw;
		}
		catch (JsonReaderException ex)
		{
#pragma warning disable S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			_logger.LogWarning("JsonReaderException: {Message} - Invalid JSON: {Json}", ex.Message, sourceJson);
#pragma warning restore S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			throw;
		}
	}

	/// <summary>
	/// gets the field name for property
	/// </summary>
	public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
		=> _serializerIgnore.GetFieldNameForProperty(propertyInfo);

	/// <summary>
	/// Serializes an object to HTTP content
	/// </summary>
	/// <typeparam name="T">The type of the object to serialize</typeparam>
	/// <param name="item">The object to serialize</param>
	/// <returns>The HTTP content containing the serialized object</returns>
	public HttpContent ToHttpContent<T>(T item)
		=> _serializerIgnore.ToHttpContent(item);
}
