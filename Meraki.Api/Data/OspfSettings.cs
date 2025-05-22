namespace Meraki.Api.Data;

/// <summary>
/// OSPF settings
/// </summary>
[DataContract]
public class OspfSettings
{
	/// <summary>
	/// The OSPF area to which this interface should belong. Can be either 'disabled' or the identifier of an existing OSPF area.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "area")]
	public string Area { get; set; } = string.Empty;

	/// <summary>
	/// The path cost for this interface. Defaults to 1, but can be increased up to 65535 to give lower priority.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "cost")]
	public int Cost { get; set; }

	/// <summary>
	/// When enabled, OSPF will not run on the interface, but the subnet will still be advertised.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isPassiveEnabled")]
	public bool IsPassiveEnabled { get; set; }

	/// <summary>
	/// OSPF Settings - Undocumented 2025-05-04, observed value of "broadcast"
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "networkType")]
	public string? NetworkType { get; set; }
}
