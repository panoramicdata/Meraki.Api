using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network settings
	/// </summary>
	[DataContract]
	public class NetworkSettings
	{
		/// <summary>
		/// Local status page enabled?
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "localStatusPageEnabled")]
		public bool LocalStatusPageEnabled { get; set; }

		/// <summary>
		/// Remote status page enabled?
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "remoteStatusPageEnabled")]
		public bool RemoteStatusPageEnabled { get; set; }

		/// <summary>
		/// Secure connect settings
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "secureConnect")]
		public SecureConnect? SecureConnect { get; set; } = new();

		/// <summary>
		/// Fips settings
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "fips")]
		public SecureConnect Fips { get; set; } = new();
	}
}
