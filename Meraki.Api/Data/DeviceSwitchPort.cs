using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A device switch port
	/// </summary>
	[DataContract]
	public class DeviceSwitchPort : NamedItem
	{
		/// <summary>
		/// number
		/// </summary>
		[DataMember(Name = "number")]
		public int Number { get; set; }

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// poeEnabled
		/// </summary>
		[DataMember(Name = "poeEnabled")]
		public bool PoeEnabled { get; set; }

		/// <summary>
		/// type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// vlan
		/// </summary>
		[DataMember(Name = "vlan")]
		public int Vlan { get; set; }

		/// <summary>
		/// voiceVlan
		/// </summary>
		[DataMember(Name = "voiceVlan")]
		public int? VoiceVlan { get; set; }

		/// <summary>
		/// allowedVlans
		/// </summary>
		[DataMember(Name = "allowedVlans")]
		public string AllowedVlans { get; set; } = string.Empty;

		/// <summary>
		/// isolationEnabled
		/// </summary>
		[DataMember(Name = "isolationEnabled")]
		public bool IsolationEnabled { get; set; }

		/// <summary>
		/// rstpEnabled
		/// </summary>
		[DataMember(Name = "rstpEnabled")]
		public bool RstpEnabled { get; set; }

		/// <summary>
		/// stpGuard
		/// </summary>
		[DataMember(Name = "stpGuard")]
		public string StpGuard { get; set; } = string.Empty;

		/// <summary>
		/// linkNegotiation
		/// </summary>
		[DataMember(Name = "linkNegotiation")]
		public string LinkNegotiation { get; set; } = string.Empty;

		/// <summary>
		/// accessPolicyNumber
		/// </summary>
		[DataMember(Name = "accessPolicyNumber")]
		public string AccessPolicyNumber { get; set; } = string.Empty;

		/// <summary>
		/// portScheduleId
		/// </summary>
		[DataMember(Name = "portScheduleId")]
		public string PortScheduleId { get; set; } = string.Empty;

		/// <summary>
		/// udld
		/// </summary>
		[DataMember(Name = "udld")]
		public string Udld { get; set; } = string.Empty;

		/// <summary>
		/// macWhitelist
		/// </summary>
		[DataMember(Name = "macWhitelist")]
		public List<string> MacWhitelist { get; set; } = new List<string>();

		/// <summary>
		/// stickyMacWhitelist
		/// </summary>
		[DataMember(Name = "stickyMacWhitelist")]
		public List<string> StickyMacWhitelist { get; set; } = new List<string>();

		/// <summary>
		/// stickyMacWhitelistLimit
		/// </summary>
		[DataMember(Name = "stickyMacWhitelistLimit")]
		public int? StickyMacWhitelistLimit { get; set; }

		/// <summary>
		/// stormControlEnabled
		/// </summary>
		[DataMember(Name = "stormControlEnabled")]
		public bool StormControlEnabled { get; set; }
	}
}