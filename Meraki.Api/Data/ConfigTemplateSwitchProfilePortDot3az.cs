namespace Meraki.Api.Data;

/// <summary>
/// dot3az settings for the port
/// </summary>
[DataContract]
public class ConfigTemplateSwitchProfilePortDot3az
{
	/// <summary>
	/// The Energy Efficient Ethernet status of the switch template port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dot3az")]
	public bool? Dot3az { get; set; }
}