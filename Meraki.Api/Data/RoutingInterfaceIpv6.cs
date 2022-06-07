namespace Meraki.Api.Data;

/// <summary>
/// ipv6 Settings
/// </summary>
[DataContract]
public class RoutingInterfaceIpv6
{
	/// <summary>
	/// The IPv6 address of the interface. Required if assignmentMode is included and set as 'static'. Must not be included if assignmentMode is 'eui-64'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "address")]
	public string? Address { get; set; } = string.Empty;

	/// <summary>
	/// The IPv6 assignment mode for the interface. Can be either 'eui-64' or 'static'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assignmentMode")]
	public AssignmentMode? AssignmentMode { get; set; }

	/// <summary>
	///The IPv6 default gateway of the interface. Required if prefix is defined and this is the first interface with IPv6 configured for the switch.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// The IPv6 default gateway of the interface. Required if prefix is defined and this is the first interface with IPv6 configured for the switch.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "prefix")]
	public string? Prefix { get; set; }
}
