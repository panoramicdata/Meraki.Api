namespace Meraki.Api.Data;

/// <summary>
/// Port specific details
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorUpdateRequestSourcePort
{
	/// <summary>
	/// Source port involve in port mirroring
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Source port's switch serial id
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Source port module details
	/// </summary>
	[DataMember(Name = "module")]
	public NetworksSwitchStackPortsMirrorUpdateRequestSourcePortModule? Module { get; set; }
}
