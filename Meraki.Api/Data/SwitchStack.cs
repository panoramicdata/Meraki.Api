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
	[Obsolete("This property is deprecated from API v1.61")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isMonitorOnly")]
	public bool IsMonitorOnly { get; set; }

	/// <summary>
	/// Members - Undocumented
	/// </summary>
	[Obsolete("This property is deprecated from API v1.61")]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "members")]
	public List<SwitchStackMember> Members { get; set; } = [];

	/// <summary>
	/// The virtual MAC address of the switch stack
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "virtualMac")]
	public string? VirtualMac { get; set; }

	/// <summary>
	/// ID of the workflow
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "workflowId")]
	public string? WorkflowId { get; set; }
}
