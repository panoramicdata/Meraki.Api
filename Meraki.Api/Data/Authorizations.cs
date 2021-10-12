using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Authorizations
	/// </summary>
	[DataContract]
	public class Authorizations
	{
		/// <summary>
		/// SSID for which the user is being authorized
		/// </summary>
		[ApiAccess(ApiAccess.CreateUpdate)]
		[DataMember(Name = "ssidNumber")]
		public int SsidNumber { get; set; }

		/// <summary>
		/// Authorized zone
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "authorizedZone")]
		public string AuthorizedZone { get; set; } = string.Empty;

		/// <summary>
		/// Date for authorization to expire. Default is for authorization to not expire.
		/// </summary>
		[ApiAccess(ApiAccess.CreateUpdate)]
		[DataMember(Name = "expiresAt")]
		public string ExpiresAt { get; set; } = string.Empty;

		/// <summary>
		/// Authorized by name
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "authorizedByName")]
		public string AuthorizedByName { get; set; } = string.Empty;

		/// <summary>
		/// Authorized by email
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "authorizedByEmail")]
		public string authorizedByEmail { get; set; } = string.Empty;
	}
}
