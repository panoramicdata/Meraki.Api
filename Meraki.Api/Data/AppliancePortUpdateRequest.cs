namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkAppliancePort
/// </summary>
[DataContract]
public class AppliancePortUpdateRequest
{
	/// <summary>
	/// Number
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The status of the port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// The type of the port: 'access' or 'trunk'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public SwitchPortType? Type { get; set; }

	/// <summary>
	/// Trunk port can Drop all Untagged traffic. When true, no VLAN is required. Access ports cannot have dropUntaggedTraffic set to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dropUntaggedTraffic")]
	public bool? DropUntaggedTraffic { get; set; }

	/// <summary>
	/// Native VLAN when the port is in Trunk mode. Access VLAN when the port is in Access mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Comma-delimited list of the VLAN ID's allowed on the port, or 'all' to permit all VLAN's on the port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// The name of the policy. Only applicable to Access ports. Valid values are: 'open', '8021x-radius', 'mac-radius', 'hybris-radius' for MX64 or Z3 or any MX supporting the per port authentication feature. Otherwise, 'open' is the only valid value and 'open' is the default value if the field is missing.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "accessPolicy")]
	public string? AccessPolicy { get; set; }
}
