namespace Meraki.Api.Data;

/// <summary>
/// Endpoint HTTP server information
/// </summary>
[DataContract]
public class NetworksLocationScanningHttpServer
{
	/// <summary>
	/// Identifier for the HTTP server
	/// </summary>
	[DataMember(Name = "id")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Id { get; set; }

	/// <summary>
	/// The name of the HTTP server
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Name { get; set; }

	/// <summary>
	/// A Meraki Network ID
	/// </summary>
	[DataMember(Name = "networkId")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? NetworkId { get; set; }

	/// <summary>
	/// Shared secret for the HTTP server
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// URL where the HTTP server may be reached
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Url { get; set; }

	/// <summary>
	/// Timestamp, in ISO8601 format, when the HTTP server was validated
	/// </summary>
	[DataMember(Name = "validatedAt")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? ValidatedAt { get; set; }

	/// <summary>
	/// Validator for the HTTP server
	/// </summary>
	[DataMember(Name = "validator")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string? Validator { get; set; }
}