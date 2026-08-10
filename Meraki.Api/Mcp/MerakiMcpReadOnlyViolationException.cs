namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when a caller attempts to execute a non-read capability through the MCP server.
/// </summary>
/// <remarks>
/// The Meraki MCP server's execute_api tool is read-only by design. Mutations must be performed
/// through <see cref="MerakiClient"/>, which talks to the Meraki Dashboard REST API directly.
/// </remarks>
public class MerakiMcpReadOnlyViolationException : MerakiMcpException
{
	/// <summary>
	/// The capability identifier that was refused.
	/// </summary>
	public string CapabilityId { get; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpReadOnlyViolationException"/> class.
	/// </summary>
	public MerakiMcpReadOnlyViolationException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpReadOnlyViolationException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpReadOnlyViolationException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpReadOnlyViolationException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpReadOnlyViolationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	private MerakiMcpReadOnlyViolationException(string capabilityId, string message)
		: base(message)
	{
		CapabilityId = capabilityId;
	}

	/// <summary>
	/// Creates an exception describing a capability that was refused because it is not a read operation.
	/// </summary>
	/// <param name="capabilityId">The capability identifier that was refused.</param>
	/// <returns>The exception to throw.</returns>
	public static MerakiMcpReadOnlyViolationException ForCapability(string capabilityId)
		=> new(capabilityId, BuildMessage(capabilityId));

	private static string BuildMessage(string capabilityId)
		=> $"Capability '{capabilityId}' does not appear to be a read operation, and the Meraki MCP server's execute_api tool is read-only by design. " +
			$"Perform this mutation with {nameof(MerakiClient)} against the Meraki Dashboard REST API instead. " +
			$"If Cisco has changed its capability naming during the beta, set {nameof(MerakiMcpClientOptions)}.{nameof(MerakiMcpClientOptions.EnforceReadOnlyCapabilityNames)} to false.";
}
