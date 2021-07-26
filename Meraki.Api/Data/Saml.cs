using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Saml
	/// </summary>
	[DataContract]
	public class Saml
	{
		/// <summary>
		/// Enabled?
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }
	}
}
