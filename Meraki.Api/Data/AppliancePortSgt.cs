namespace Meraki.Api.Data;

/// <summary>
/// Security Group Tag settings for an appliance port
/// </summary>
[DataContract]
public class AppliancePortSgt
{
	/// <summary>
	/// Adaptive policy group ID this port is assigned to.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public int? Id { get; set; }

	/// <summary>
	/// Whether or not Peer SGT is enabled for traffic through this port.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
