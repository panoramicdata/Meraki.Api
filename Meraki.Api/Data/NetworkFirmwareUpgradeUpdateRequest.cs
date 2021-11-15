using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Update firmware upgrade information for a network
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeUpdateRequest
{
	/// <summary>
	/// Timezone
	/// </summary>
	[DataMember(Name = "timezone")]
	public string Timezone { get; set; } = string.Empty;

	/// <summary>
	/// Products
	/// </summary>
	[DataMember(Name = "products")]
	public ProductsUpdateRequest Products { get; set; } = new();

	/// <summary>
	/// Upgrade window
	/// </summary>
	[DataMember(Name = "upgradeWindow")]
	public UpgradeWindow UpgradeWindow { get; set; } = new();
}
