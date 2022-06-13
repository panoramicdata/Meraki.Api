namespace Meraki.Api.Data;

/// <summary>
/// Settings related to radio transmission.
/// </summary>
[DataContract]
public class WirelessRfProfileTransmission
{
	/// <summary>
	/// Toggle for radio transmission. When false, radios will not transmit at all.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
