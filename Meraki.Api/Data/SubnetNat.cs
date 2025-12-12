namespace Meraki.Api.Data;

/// <summary>
/// SubnetNat - Undocumented
/// </summary>
[DataContract]
public class SubnetNat
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The translated subnet (in CIDR notation) that will be used in the VPN tunnel
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "remoteSubnet")]
	public string? RemoteSubnet { get; set; }
}
