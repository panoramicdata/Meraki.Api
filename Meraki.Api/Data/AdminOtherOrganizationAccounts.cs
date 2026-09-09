namespace Meraki.Api.Data;

/// <summary>
/// The administrator's accounts in other organizations - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class AdminOtherOrganizationAccounts
{
	/// <summary>
	/// The lockout state of the administrator's accounts in other organizations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lockout")]
	public AdminOtherOrganizationAccountsLockout? Lockout { get; set; }
}
