namespace Meraki.Api.Data;
/// <summary>
/// Uplink Wan Svis Settings for an MX Appliance
/// </summary>
[DataContract]

public class DeviceApplianceUplinkSettingsInterfacesWanSvisIpvx
{
	/// <summary>
	/// IP address and subnet mask when in static mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// The assignment mode for this SVI. Applies only when PPPoE is disabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "assignmentMode")]
	public string? AssignmentMode { get; set; }

	/// <summary>
	/// Gateway IP address when in static mode.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }

	/// <summary>
	/// The nameserver settings for this SVI.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "nameservers")]
	public DeviceApplianceUplinkSettingsInterfacesWanSvisIpvxNameservers? Nameservers { get; set; }
}