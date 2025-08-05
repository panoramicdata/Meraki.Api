namespace Meraki.Api.Data;

/// <summary>
/// Uplink usage
/// </summary>
[DataContract]
public class OrganizationApplianceUplinksUsageByNetworkItemByUplinkItem
{
	/// <summary>
	/// Bytes received
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "received")]
	public int Received { get; set; }

	/// <summary>
	/// Bytes sent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sent")]
	public int Sent { get; set; }

	/// <summary>
	/// Uplink name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}