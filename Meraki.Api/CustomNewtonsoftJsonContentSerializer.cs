namespace Meraki.Api;
/// <summary>
/// A custom IHttpContentSerializer based on NewtonsoftJsonContentSerializer
/// that reports every member a response contains but the model does not declare
/// </summary>
// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class CustomNewtonsoftJsonContentSerializer : IHttpContentSerializer, IReflectionFieldNameProvider
{
	// Newtonsoft.Json raises this, unlocalized, wherever MissingMemberHandling.Error rejects a member:
	// "Could not find member '{name}' on object of type '{type}'. Path '{path}', line 1, position 2."
	private const string MissingMemberMessagePrefix = "Could not find member '";

	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
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
		var jsonSerializerSettingsWithIgnore = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Ignore,
			Converters = [new StringEnumConverter()],
			ContractResolver = new TolerantEnumContractResolver(options, logger)
		};
		_jsonSerializerSettingsWithError = new JsonSerializerSettings
		{
			// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
			// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
			// nulls for specific properties, e.g. disassociating port schedule ids from a port
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Error,
			Converters = [new StringEnumConverter()],
			ContractResolver = new TolerantEnumContractResolver(options, logger)
		};

		_serializerIgnore = new NewtonsoftJsonContentSerializer(jsonSerializerSettingsWithIgnore);
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
		var sourceJson = await content.ReadAsStringAsync().ConfigureAwait(false);
		var collector = new MissingMemberCollector();
		T? result;
		try
		{
			result = DeserializeCollectingMissingMembers<T>(sourceJson, collector);
		}
		catch (JsonSerializationException ex)
		{
			if (!ReportMissingMembers<T>(collector, sourceJson, logWarning: true))
			{
				// Not a missing member, and none came before it: report it as this mode always has
				_logger.LogWarning(ex, "JsonSerializationException: {Message}", ex.Message);
				LogResponseJson(sourceJson);
				_options.JsonMissingMemberAction?.Invoke(typeof(T), ex, sourceJson);
			}

			throw;
		}
		catch (JsonReaderException ex)
		{
			_ = ReportMissingMembers<T>(collector, sourceJson, logWarning: true);
#pragma warning disable S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			_logger.LogWarning("JsonReaderException: {Message} - Invalid JSON: {Json}", ex.Message, sourceJson);
#pragma warning restore S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			throw;
		}

		_ = ReportMissingMembers<T>(collector, sourceJson, logWarning: true);
		return result;
	}

	private async Task<T?> LogOnErrorAndThrowFromHttpContentAsync<T>(HttpContent content)
	{
		var sourceJson = await content.ReadAsStringAsync().ConfigureAwait(false);
		var collector = new MissingMemberCollector();
		T? result;
		try
		{
			result = DeserializeCollectingMissingMembers<T>(sourceJson, collector);
		}
		catch (JsonSerializationException ex)
		{
			if (!ReportMissingMembers<T>(collector, sourceJson, logWarning: false))
			{
				// Not a missing member, and none came before it: report it as this mode always has
				LogResponseJson(sourceJson);
				_options.JsonMissingMemberAction?.Invoke(typeof(T), ex, sourceJson);
			}

			throw;
		}
		catch (JsonReaderException ex)
		{
			_ = ReportMissingMembers<T>(collector, sourceJson, logWarning: false);
#pragma warning disable S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			_logger.LogWarning("JsonReaderException: {Message} - Invalid JSON: {Json}", ex.Message, sourceJson);
#pragma warning restore S6667 // Logging in a catch clause should pass the caught exception as a parameter.
			throw;
		}

		// The actions have been called; only now is the whole list thrown
		return ReportMissingMembers<T>(collector, sourceJson, logWarning: false)
			? throw new JsonMissingMembersException(collector.MissingMembers, collector.FirstException!)
			: result;
	}
}
