namespace Meraki.Api;
/// <summary>
/// A custom IHttpContentSerializer based on NewtonsoftJsonContentSerializer
/// that reports every member a response contains but the model does not declare
/// </summary>
public class CustomNewtonsoftJsonContentSerializer : IHttpContentSerializer
{
	// Newtonsoft.Json raises this, unlocalized, wherever MissingMemberHandling.Error rejects a member:
	// "Could not find member '{name}' on object of type '{type}'. Path '{path}', line 1, position 2."
	private const string MissingMemberMessagePrefix = "Could not find member '";

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

	/// <summary>
	/// Deserializes in a single pass with MissingMemberHandling.Error, marking each missing member
	/// error handled so that the rest of the response still binds. Any other error is left unhandled
	/// and propagates exactly as it would from JsonConvert.DeserializeObject.
	/// </summary>
	private T? DeserializeCollectingMissingMembers<T>(string sourceJson, MissingMemberCollector collector)
	{
		using var stringReader = new StringReader(sourceJson);
		using var reader = new MissingMemberJsonTextReader(stringReader, collector);

		// Set up as JsonConvert.DeserializeObject does, given settings that leave CheckAdditionalContent unset
		var serializer = JsonSerializer.CreateDefault(_jsonSerializerSettingsWithError);
		serializer.CheckAdditionalContent = true;

		serializer.Error += (_, args) =>
		{
			if (!args.ErrorContext.Handled
				&& args.ErrorContext.Error is JsonSerializationException ex
				&& IsMissingMemberError(ex))
			{
				collector.Add(
					ex,
					args.ErrorContext.OriginalObject?.GetType().Name ?? GetTypeNameFromMessage(ex.Message),
					args.ErrorContext.Member as string ?? string.Empty,
					args.ErrorContext.Path ?? string.Empty);

				// Newtonsoft skips the member's value next; the reader records what is inside it
				reader.CaptureMembersInside(reader.Depth);
				args.ErrorContext.Handled = true;
			}
		};

		return serializer.Deserialize<T>(reader);
	}

	/// <summary>
	/// Logs and passes any missing members found to the configured actions
	/// </summary>
	/// <returns>Whether any missing members were found</returns>
	private bool ReportMissingMembers<T>(MissingMemberCollector collector, string sourceJson, bool logWarning)
	{
		if (collector.FirstException is not { } firstException)
		{
			return false;
		}

		if (logWarning)
		{
#pragma warning disable CA1873 // Avoid potentially expensive logging
			_logger.LogWarning(
				firstException,
				"JsonSerializationException: {Message}",
				JsonMissingMembersException.BuildMessage(collector.MissingMembers, firstException));
#pragma warning restore CA1873 // Avoid potentially expensive logging
		}

		LogResponseJson(sourceJson);

		// Superseded by JsonMissingMembersAction, but still called once, with the first member, as before
		_options.JsonMissingMemberAction?.Invoke(typeof(T), firstException, sourceJson);
		_options.JsonMissingMembersAction?.Invoke(typeof(T), collector.MissingMembers, sourceJson);
		return true;
	}

	private void LogResponseJson(string sourceJson)
	{
		if (_options.JsonMissingMemberResponseLogLevel != LogLevel.None)
		{
#pragma warning disable CA1873 // Avoid potentially expensive logging
			_logger.Log(_options.JsonMissingMemberResponseLogLevel, "Missing Member Response JSON:\n{SourceJson}", sourceJson);
#pragma warning restore CA1873 // Avoid potentially expensive logging
		}
	}

	private static bool IsMissingMemberError(JsonSerializationException ex)
		=> ex.Message.StartsWith(MissingMemberMessagePrefix, StringComparison.Ordinal);

	// Only needed where Newtonsoft does not supply the object, e.g. a type bound through its constructor
	private static string GetTypeNameFromMessage(string message)
	{
		// Split on quotes: Could not find member, name, on object of type, type, then the path
		var parts = message.Split('\'');
		return parts.Length > 3 ? parts[3] : string.Empty;
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

	/// <summary>
	/// The missing members found in one response, in document order
	/// </summary>
	private sealed class MissingMemberCollector
	{
		private List<JsonMissingMember>? _missingMembers;

		public IReadOnlyList<JsonMissingMember> MissingMembers => _missingMembers ?? [];

		public JsonSerializationException? FirstException { get; private set; }

		/// <summary>
		/// The type that lacks the member whose contents are being recorded
		/// </summary>
		public string CapturingDeclaringType { get; private set; } = string.Empty;

		public void Add(JsonSerializationException ex, string declaringType, string memberName, string path)
		{
			FirstException ??= ex;
			CapturingDeclaringType = declaringType;
			Add(new JsonMissingMember(declaringType, memberName, path));
		}

		public void Add(JsonMissingMember missingMember)
		{
			_missingMembers ??= [];
			_missingMembers.Add(missingMember);
		}
	}

	/// <summary>
	/// A JsonTextReader that, once told a member is missing, records every property inside that
	/// member's value while Newtonsoft skips it, so members nested inside a missing member are
	/// reported too
	/// </summary>
	private sealed class MissingMemberJsonTextReader(TextReader reader, MissingMemberCollector collector) : JsonTextReader(reader)
	{
		private int _captureDepth = -1;

		public void CaptureMembersInside(int depth)
			=> _captureDepth = depth;

		public override bool Read()
		{
			var read = base.Read();
			if (_captureDepth >= 0)
			{
				// The missing member's value sits at the member's own depth and its contents are deeper.
				// A property at that depth is the next sibling; anything shallower ends the parent object.
				if (!read || Depth < _captureDepth || (Depth == _captureDepth && TokenType == JsonToken.PropertyName))
				{
					_captureDepth = -1;
				}
				else if (Depth > _captureDepth && TokenType == JsonToken.PropertyName)
				{
					collector.Add(new JsonMissingMember(collector.CapturingDeclaringType, (string)Value!, Path));
				}
			}

			return read;
		}
	}
}
