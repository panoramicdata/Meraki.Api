namespace Meraki.Api.Data;

/// <summary>
/// The Staged Upgrade Group
/// </summary>
[DataContract]
public class NetworkFirmwareUpgradesStagedStageUpdateStagedGroup
{
	/// <summary>
	/// ID of the Staged Upgrade Group
	/// </summary>
	[DataMember(Name = "Id")]
	public string Id { get; set; } = string.Empty;
}