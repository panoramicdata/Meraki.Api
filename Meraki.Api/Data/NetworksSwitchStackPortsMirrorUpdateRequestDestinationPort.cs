namespace Meraki.Api.Data;

/// <summary>
/// Port specific details
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorUpdateRequestDestinationPort
{
	/// <summary>
	/// Destination port involve in port mirroring
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Destination port's switch serial id
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Destination port module details
	/// </summary>
	[DataMember(Name = "module")]
	public NetworksSwitchStackPortsMirrorUpdateRequestDestinationPortModule? Module { get; set; }
}
