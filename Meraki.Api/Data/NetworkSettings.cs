using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
		[DataMember(Name = "localStatusPageEnabled")]
		public bool LocalStatusPageEnabled { get; set; }

		/// <summary>
		/// Remote status page enabled?
		/// </summary>
		[DataMember(Name = "remoteStatusPageEnabled")]
		public bool RemoteStatusPageEnabled { get; set; }

		/// <summary>
		/// Secure connect settings
		/// </summary>
		[DataMember(Name = "secureConnect")]
		public SecureConnect? SecureConnect { get; set; } = new();

		/// <summary>
		/// Fips settings
		/// </summary>
		[DataMember(Name = "fips")]
		public SecureConnect Fips { get; set; } = new();
	}
}
