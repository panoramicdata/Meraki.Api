namespace Meraki.Api.Data;

/// <summary>
/// The version to be updated to for switch devices
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsCreateRequestNextUpgradeToVersion
{
	/// <summary>
	/// The version ID
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}