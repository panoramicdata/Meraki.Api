namespace Meraki.Api.Data;

/// <summary>
/// The Spanning Tree Protocol (STP) information of the connected device.
/// </summary>
[DataContract]
public class SwitchPortStatusSpanningTree
{
	/// <summary>
	/// The current Spanning Tree Protocol statuses of the port.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "statuses")]
	public List<string>? Statuses { get; set; }

}
