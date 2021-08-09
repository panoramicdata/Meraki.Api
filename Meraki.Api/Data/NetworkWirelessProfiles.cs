using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network wireless profiles
	/// </summary>
	[DataContract]
	public class NetworkWirelessProfiles
	{
		/// <summary>
		/// The name of the camera wireless profile.
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Applied device count
		/// </summary>
		[DataMember(Name = "appliedDeviceCount")]
		public int AppliedDeviceCount { get; set; }

		/// <summary>
		/// The identity of the wireless profile. Required for creating wireless profiles in 8021x-radius auth mode.
		/// </summary>
		[DataMember(Name = "identity")]
		public WirelessProfilesIdentity Identity { get; set; } = new();

		/// <summary>
		/// The details of the SSID config.
		/// </summary>
		[DataMember(Name = "ssid")]
		public WirelessProfilesSsid Ssid { get; set; } = new();
	}
}
