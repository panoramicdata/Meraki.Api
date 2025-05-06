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
	[ApiAccess(ApiAccess.Create)]
	public string Id { get; set; } = string.Empty;
}