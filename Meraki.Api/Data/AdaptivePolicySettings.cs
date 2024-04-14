namespace Meraki.Api.Data;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public class AdaptivePolicySettings
{
	/// <summary>
	/// List of network IDs with adaptive policy enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabledNetworks")]
	public List<string> EnabledNetworks { get; set; } = [];
}
