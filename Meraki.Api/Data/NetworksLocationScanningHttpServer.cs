namespace Meraki.Api.Data;

/// <summary>
/// Endpoint HTTP server information
/// </summary>
public class NetworksLocationScanningHttpServer
{
	/// <summary>
	/// Identifier for the HTTP server
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The name of the HTTP server
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// A Meraki Network ID
	/// </summary>
	[DataMember(Name = "networkId")]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Shared secret for the HTTP server
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// URL where the HTTP server may be reached
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601 format, when the HTTP server was validated
	/// </summary>
	[DataMember(Name = "validatedAt")]
	public string? ValidatedAt { get; set; }

	/// <summary>
	/// Validator for the HTTP server
	/// </summary>
	[DataMember(Name = "validator")]
	public string? Validator { get; set; }
}