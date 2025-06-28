namespace Meraki.Api.Data;

/// <summary>
/// Packets sent from a client to an AP.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPacketLossItemUpstream
{
	/// <summary>
	/// Total packets sent by a client and did not reach the AP.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lost")]
	public int Lost { get; set; }

	/// <summary>
	/// Total packets sent by a client to an AP.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Percentage of lost packets.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lossPercentage")]
	public int LossPercentage { get; set; }
}