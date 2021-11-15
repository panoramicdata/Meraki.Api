namespace Meraki.Api.Data;

/// <summary>
/// The VLAN tagging settings for your group policy. Only available if your network has a wireless configuration.
/// </summary>
[DataContract]
public class VlanTagging
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[DataMember(Name = "settings")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public Setting Settings { get; set; }

	/// <summary>
	/// The ID of the vlan you want to tag. This only applies if 'settings' is set to 'custom'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public string? VlanId { get; set; }
}
