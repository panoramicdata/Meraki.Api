namespace Meraki.Api.Data;

/// <summary>
/// dot3az settings for the port
/// </summary>
[DataContract]
public class SwitchPortDot3az
{
	/// <summary>
	/// The Energy Efficient Ethernet status of the switch port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
