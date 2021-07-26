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
	}
}
