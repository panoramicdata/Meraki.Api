namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN Controller tags
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsUnassignedItemTags
{
	/// <summary>
	/// Policy tag
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// RF tag
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rf")]
	public string Rf { get; set; } = string.Empty;

	/// <summary>
	/// Site tag
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "site")]
	public string Site { get; set; } = string.Empty;
}