namespace Meraki.Api.Exceptions;

/// <summary>
/// Thrown, when <see cref="MerakiClientOptions.JsonMissingMemberHandling"/> is
/// <see cref="JsonMissingMemberHandling.ThrowOnError"/>, once a response has been read to the end and found
/// to contain members that the model does not declare. It is a <see cref="JsonSerializationException"/>,
/// so existing handlers still catch it, and its <see cref="Exception.InnerException"/> is the exception
/// Newtonsoft.Json raised for the first missing member.
/// </summary>
public class JsonMissingMembersException : JsonSerializationException
{
	/// <summary>
	/// Initializes a new instance of the JsonMissingMembersException class
	/// </summary>
	public JsonMissingMembersException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the JsonMissingMembersException class with a specified error message
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	public JsonMissingMembersException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the JsonMissingMembersException class with a specified error message and inner exception
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	/// <param name="innerException">The exception that is the cause of the current exception</param>
	public JsonMissingMembersException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the JsonMissingMembersException class with the missing members found
	/// </summary>
	/// <param name="missingMembers">Every missing member found in the response, in document order</param>
	/// <param name="firstException">The exception Newtonsoft.Json raised for the first missing member</param>
	public JsonMissingMembersException(IReadOnlyList<JsonMissingMember> missingMembers, JsonSerializationException firstException)
		: base(BuildMessage(missingMembers, firstException), firstException.Path ?? string.Empty, firstException.LineNumber, firstException.LinePosition, firstException)
	{
		MissingMembers = missingMembers;
	}

	/// <summary>
	/// Every missing member found in the response, in document order
	/// </summary>
	public IReadOnlyList<JsonMissingMember> MissingMembers { get; } = [];

	/// <summary>
	/// The first missing member's message, as Newtonsoft.Json words it, followed by the others' paths
	/// </summary>
	internal static string BuildMessage(IReadOnlyList<JsonMissingMember> missingMembers, JsonSerializationException firstException)
		=> missingMembers.Count <= 1
			? firstException.Message
			: $"{firstException.Message} {missingMembers.Count - 1} further missing member(s): {string.Join(", ", missingMembers.Skip(1).Select(m => $"'{m.Path}' on {m.DeclaringType}"))}";
}
