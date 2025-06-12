namespace Meraki.Api.Data;

/// <summary>
/// Channel settings
/// </summary>
[DataContract]
public class NetworkWirelessRadioAutoRfUpdateResponseChannel
{
	/// <summary>
	/// Channel avoidance settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "avoidance")]
	public NetworkWirelessRadioAutoRfUpdateResponseChannelAvoidance Avoidance { get; set; } = new();
}
