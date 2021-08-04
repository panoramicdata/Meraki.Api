using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	///	Login security
	/// </summary>
	[DataContract]
	public class LoginSecurity
	{
		/// <summary>
		/// Enforce password expiration
		/// </summary>
		[DataMember(Name = "enforcePasswordExpiration")]
		public bool EnforcePasswordExpiration { get; set; }

		/// <summary>
		/// Password expiration days
		/// </summary>
		[DataMember(Name = "passwordExpirationDays")]
		public int PasswordExpirationDays { get; set; }

		/// <summary>
		/// Enforce different passwords
		/// </summary>
		[DataMember(Name = "enforceDifferentPasswords")]
		public bool EnforceDifferentPasswords { get; set; }

		/// <summary>
		/// Num different passwords
		/// </summary>
		[DataMember(Name = "numDifferentPasswords")]
		public int NumDifferentPasswords { get; set; }

		/// <summary>
		/// Enforce strong passwords
		/// </summary>
		[DataMember(Name = "enforceStrongPasswords")]
		public bool EnforceStrongPasswords { get; set; }

		/// <summary>
		/// Enforce account lockout
		/// </summary>
		[DataMember(Name = "enforceAccountLockout")]
		public bool EnforceAccountLockout { get; set; }

		/// <summary>
		/// Account lockout attempts
		/// </summary>
		[DataMember(Name = "accountLockoutAttempts")]
		public int AccountLockoutAttempts { get; set; }

		/// <summary>
		/// Enforce idle timeout
		/// </summary>
		[DataMember(Name = "enforceIdleTimeout")]
		public bool EnforceIdleTimeout { get; set; }

		/// <summary>
		/// Idle timeout minutes
		/// </summary>
		[DataMember(Name = "idleTimeoutMinutes")]
		public int IdleTimeoutMinutes { get; set; }

		/// <summary>
		/// Enforce two factor auth
		/// </summary>
		[DataMember(Name = "enforceTwoFactorAuth")]
		public bool EnforceTwoFactorAuth { get; set; }

		/// <summary>
		/// Enforce login ip ranges
		/// </summary>
		[DataMember(Name = "enforceLoginIpRanges")]
		public bool EnforceLoginIpRanges { get; set; }

		/// <summary>
		/// Login ip ranges
		/// </summary>
		[DataMember(Name = "loginIpRanges")]
		public List<string> LoginIpRanges { get; set; } = new();	
	}
}
