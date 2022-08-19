namespace Meraki.Api.Data;

/// <summary>
/// A VPN split tunnel rule
/// </summary>
[DataContract]
public class SplitTunnelRule
{
	/// <summary>
	/// Protocol for this split tunnel rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public string? Protocol { get; set; }

	/// <summary>
	/// Destination for this split tunnel rule. IP address, fully-qualified domain names (FQDN) or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destCidr")]
	public string DestCidr { get; set; } = string.Empty;

	/// <summary>
	/// Destination port for this split tunnel rule, (integer in the range 1-65535), or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destPort")]
	public string DestPort { get; set; } = string.Empty;

	/// <summary>
	/// Traffic policy specified for this split tunnel rule, 'allow' or 'deny'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Description for this split tunnel rule (optional).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;
}
