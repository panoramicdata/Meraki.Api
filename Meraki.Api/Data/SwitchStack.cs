namespace Meraki.Api.Data;

/// <summary>
/// A switch stack
/// </summary>
[DataContract]
public class SwitchStack : NamedIdentifiedItem
{
	public const int MaxNameLength = 38;

	/// <summary>
	/// Serials
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// IsMonitorOnly - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isMonitorOnly")]
	public bool IsMonitorOnly { get; set; }

	/// <summary>
	/// Members - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "members")]
	public List<SwitchStackMember> Members { get; set; } = [];

	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "virtualMac")]
	public string? VirtualMac { get; set; }
}
