namespace Meraki.Api.Data;

/// <summary>
/// Details of the version the device will upgrade to
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradeStagedEventsSwitchNextUpgradeToVersion
{
	/// <summary>
	/// Id of the Version being upgraded to
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Firmware version short name
	/// </summary>
	[DataMember(Name = "shortName")]
	public string? ShortName { get; set; }
}