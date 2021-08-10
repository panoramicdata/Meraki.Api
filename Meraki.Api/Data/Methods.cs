using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Methods
	/// </summary>
	[DataContract]
	public class Methods
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Authentication types
		/// </summary>
		[DataMember(Name = "authenticationTypes")]
		public AuthenticationTypes AuthenticationTypes { get; set; } = new();
	}
}
