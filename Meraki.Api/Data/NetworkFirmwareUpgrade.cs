using System.Runtime.Serialization;

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
	[DataMember(Name = "upgradeWindow")]
	public UpgradeWindow UpgradeWindow { get; set; } = new();

	/// <summary>
	/// Timezone
	/// </summary>
	[DataMember(Name = "timezone")]
	public string Timezone { get; set; } = string.Empty;

	/// <summary>
	/// Products
	/// </summary>
	[DataMember(Name = "products")]
	public Products Products { get; set; } = new();
}
