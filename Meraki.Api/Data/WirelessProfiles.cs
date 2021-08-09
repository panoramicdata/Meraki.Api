using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Wireless profiles
	/// </summary>
	[DataContract]
	public class WirelessProfiles
	{
		/// <summary>
		/// The ids of the wireless profile to assign to the given camera
		/// </summary>
		[DataMember(Name = "ids")]
		public WirelessProfilesIds Ids { get; set; } = new();
	}
}
