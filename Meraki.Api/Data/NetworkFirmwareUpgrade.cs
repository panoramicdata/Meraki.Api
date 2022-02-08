namespace Meraki.Api.Data;

/// <summary>
/// Network Firmware Upgrade
/// </summary>
[DataContract]
public class NetworkFirmwareUpgrade
{
	/// <summary>
	/// Upgrade window
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "upgradeWindow")]
	public UpgradeWindow UpgradeWindow { get; set; } = new();

	/// <summary>
	/// Timezone
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timezone")]
	public string Timezone { get; set; } = string.Empty;

	/// <summary>
	/// Products
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "products")]
	public Products Products { get; set; } = new();
}
