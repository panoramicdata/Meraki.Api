namespace Meraki.Api.Data;

/// <summary>
/// Packets sent from an AP to a client.
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesPacketLossItemDownstream
{
	/// <summary>
	/// Total packets sent by an AP that did not reach the client.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lost")]
	public int Lost { get; set; }

	/// <summary>
	/// Total packets received by a client.
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