namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class CustomNewtonsoftJsonContentSerializer
{
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
}
