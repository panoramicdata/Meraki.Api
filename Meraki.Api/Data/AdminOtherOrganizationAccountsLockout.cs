namespace Meraki.Api.Data;

/// <summary>
/// The lockout state of an administrator's accounts in other organizations
/// </summary>
[DataContract]
public class AdminOtherOrganizationAccountsLockout
{
	/// <summary>
	/// Whether the administrator is locked out of their accounts in other organizations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isLocked")]
	public bool? IsLocked { get; set; }
}
