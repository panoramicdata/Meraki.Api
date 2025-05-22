namespace Meraki.Api.Data;

/// <summary>
/// DeviceSwitchPortsPort
/// </summary>
[DataContract]
public class DeviceSwitchPortsMirrorPort
{
	/// <summary>
	/// Destination Switch Port Number
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Source port module details
	/// </summary>
	[DataMember(Name = "module")]
	public DeviceSwitchPortsMirrorPortModule? Module { get; set; }
}
