namespace Meraki.Api.Data;

/// <summary>
/// Object for RADIUS Settings
/// </summary>
[DataContract]
public class Radius
{
	/// <summary>
	/// VLAN that clients will be placed on when RADIUS authentication fails. Will be null if hostMode is Multi-Auth
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "failedAuthVlanId")]
	public string? FailedAuthVlanId { get; set; }

	/// <summary>
	/// Re-authentication period in seconds.Will be null if hostMode is Multi-Auth
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "reAuthenticationInterval")]
	public int? ReAuthnicationInterval { get; set; }

	/// <summary>
	/// Critical auth settings for when authentication is rejected by the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "criticalAuth")]
	public CriticalAuth CriticalAuth { get; set; } = new();
}
