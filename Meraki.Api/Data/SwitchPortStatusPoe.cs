namespace Meraki.Api.Data;

/// <summary>
/// PoE status of the port.
/// </summary>
[DataContract]
public class SwitchPortStatusPoe
{
	/// <summary>
	/// Whether the port is drawing power
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isAllocated")]
	public bool IsAllocated { get; set; }
}
