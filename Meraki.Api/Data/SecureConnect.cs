using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Secure connect settings
	/// </summary>
	[DataContract]
	public partial class SecureConnect
	{
		/// <summary>
		/// Enabled?
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Active
		/// </summary>
		[DataMember(Name = "active")]
		public bool Active { get; set; }

		/// <summary>
		/// Authentication status
		/// </summary>
		[DataMember(Name = "authenticationStatus")]
		public string AuthenticationStatus { get; set; } = string.Empty;

		/// <summary>
		/// Config overrides
		/// </summary>
		[DataMember(Name = "configOverrides")]
		public ConfigOverrides ConfigOverrides { get; set; } = new();
	}
}
