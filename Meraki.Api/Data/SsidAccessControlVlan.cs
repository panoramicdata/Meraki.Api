namespace Meraki.Api.Data;

/// <summary>
/// SSID access control VLAN settings
/// </summary>
[DataContract]
public class SsidAccessControlVlan
{
	/// <summary>
	/// Whether VLAN is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The VLAN tag
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tag")]
	public string? Tag { get; set; }
}
