namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Dhcp Server Policy Arp Inspection Warning
/// </summary>
[DataContract]
public class NetworksSwitchDhcpServerPolicyArpInspectionWarning
{
	/// <summary>
	/// Switch name.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Switch serial.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Url link to switch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Whether this switch has a trusted DAI port. Always false if supportsInspection is false.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hasTrustedPort")]
	public bool HasTrustedPort { get; set; }

	/// <summary>
	/// Whether this switch supports Dynamic ARP Inspection.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supportsInspection")]
	public bool SupportsInspection { get; set; }
}
