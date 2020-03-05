using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An administrator
	/// </summary>
	[DataContract]
	public class Admin : NamedItem
	{
		/// <summary>
		/// The administrator's Email
		/// </summary>
		[DataMember(Name = "email")]
		public string Email { get; set; } = string.Empty;

		/// <summary>
		/// The administrator's organization Access
		/// </summary>
		[DataMember(Name = "orgAccess")]
		public string OrganizationAccess { get; set; } = string.Empty;

		/// <summary>
		/// Account status
		/// </summary>
		[DataMember(Name = "accountStatus")]
		public string AccountStatus { get; set; } = string.Empty;

		/// <summary>
		/// Whether two factor authorization is enabled
		/// </summary>
		[DataMember(Name = "twoFactorAuthEnabled")]
		public bool TwoFactorAuthEnabled { get; set; }

		/// <summary>
		/// Whether the administrator has an API key
		/// </summary>
		[DataMember(Name = "hasApiKey")]
		public bool HasApiKey { get; set; }

		/// <summary>
		/// Last active
		/// </summary>
		[DataMember(Name = "lastActive")]
		public string LastActive { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new List<string>();

		/// <summary>
		/// Network access permissions
		/// </summary>
		[DataMember(Name = "networks")]
		public List<AdminNetworkAccess> Networks { get; set; } = new List<AdminNetworkAccess>();
	}
}