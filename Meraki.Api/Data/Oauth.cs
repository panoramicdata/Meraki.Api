using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The OAuth settings of this SSID. Only valid if splashPage is 'Google OAuth'.
	/// </summary>
	public partial class Oauth
	{
		/// <summary>
		/// (Optional) The list of domains allowed access to the network.
		/// </summary>
		[DataMember(Name = "allowedDomains")]
		public List<string>? AllowedDomains { get; set; }
	}
}
