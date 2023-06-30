namespace Meraki.Api.Data;

/// <summary>
/// Network device to be updated
/// </summary>
[DataContract]
public class NetworkFirmwareUpdateRequestProduct
{
	/// <summary>
	/// Whether or not the network wants beta firmware
	/// </summary>
	[DataMember(Name = "participateInNextBetaRelease")]
	public bool? ParticipateInNextBetaRelease { get; set; }

	/// <summary>
	/// Next upgrade
	/// </summary>
	[DataMember(Name = "nextUpgrade")]
	public NextUpgradeUpdate NextUpgrade { get; set; } = new();
}
