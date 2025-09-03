﻿namespace Meraki.Api.Data;

/// <summary>
/// Vlan Profile
/// </summary>
[DataContract]
public class VlanProfile : NamedItem
{
	/// <summary>
	/// IName of the VLAN profile
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "iname")]
	public string? IName { get; set; }

	/// <summary>
	/// Boolean indicating the default VLAN Profile for any device that does not have a profile explicitly assigned
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isDefault")]
	public bool? IsDefault { get; set; }

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanGroups")]
	public List<VlanProfileVlanGroup>? VlanGroups { get; set; }

	/// <summary>
	/// An array of named VLANs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanNames")]
	public List<VlanProfileVlanName>? VlanNames { get; set; }

	/// <summary>
	/// Undocumented - likely a comma-separated string of active VLAN IDs - value 'all' observed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "activeVlans")]
	public string? ActiveVlans { get; set; }
}
