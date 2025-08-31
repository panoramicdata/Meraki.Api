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
	/// Group policy Number for failed authentication group policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "failedAuthGroupPolicyId")]
	public string? FailedAuthGroupPolicyId { get; set; }

	/// <summary>
	/// Security Group Tag ID for failed authentication group policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "failedAuthSgtId")]
	public int? FailedAuthSgtId { get; set; }

	/// <summary>
	/// Re-authentication period in seconds.Will be null if hostMode is Multi-Auth
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "reAuthenticationInterval")]
	public int? ReAuthenticationInterval { get; set; }

	/// <summary>
	/// Group policy Number for pre-authentication group policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "preAuthenticationGroupPolicyId")]
	public string? PreAuthenticationGroupPolicyId { get; set; }

	/// <summary>
	/// Object for authentication mode settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authentication")]
	public RadiusAuthentication? Authentication { get; set; }

	/// <summary>
	/// Critical auth settings for when authentication is rejected by the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "criticalAuth")]
	public CriticalAuth? CriticalAuth { get; set; }

	/// <summary>
	/// Object for RADIUS Cache Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "cache")]
	public RadiusCache? Cache { get; set; }

	/// <summary>
	/// suspendReAuthentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "suspendReAuthentication")]
	public bool? suspendReAuthentication { get; set; }
}
