namespace Meraki.Api.Data;

/// <summary>
///	Login security
/// </summary>
[DataContract]
public class LoginSecurity
{
	/// <summary>
	/// Enforce password expiration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforcePasswordExpiration")]
	public bool EnforcePasswordExpiration { get; set; }

	/// <summary>
	/// Password expiration days
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "passwordExpirationDays")]
	public int PasswordExpirationDays { get; set; }

	/// <summary>
	/// Enforce different passwords
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceDifferentPasswords")]
	public bool EnforceDifferentPasswords { get; set; }

	/// <summary>
	/// Num different passwords
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "numDifferentPasswords")]
	public int NumDifferentPasswords { get; set; }

	/// <summary>
	/// Enforce strong passwords
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceStrongPasswords")]
	public bool EnforceStrongPasswords { get; set; }

	/// <summary>
	/// Enforce account lockout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceAccountLockout")]
	public bool EnforceAccountLockout { get; set; }

	/// <summary>
	/// Account lockout attempts
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "accountLockoutAttempts")]
	public int AccountLockoutAttempts { get; set; }

	/// <summary>
	/// Enforce idle timeout
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceIdleTimeout")]
	public bool EnforceIdleTimeout { get; set; }

	/// <summary>
	/// Idle timeout minutes
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "idleTimeoutMinutes")]
	public int IdleTimeoutMinutes { get; set; }

	/// <summary>
	/// Enforce two factor auth
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceTwoFactorAuth")]
	public bool EnforceTwoFactorAuth { get; set; }

	/// <summary>
	/// Enforce login ip ranges
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforceLoginIpRanges")]
	public bool EnforceLoginIpRanges { get; set; }

	/// <summary>
	/// Login ip ranges
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "loginIpRanges")]
	public List<string> LoginIpRanges { get; set; } = [];

	/// <summary>
	/// ApiAuthentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "apiAuthentication")]
	public ApiAuthentication? ApiAuthentication { get; set; } = new();
}
