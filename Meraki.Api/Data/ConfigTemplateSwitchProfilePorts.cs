using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Switch profile ports
	/// </summary>
	[DataContract]
	public class ConfigTemplateSwitchProfilePorts
	{
		/// <summary>
		/// Port Id
		/// </summary>
		[DataMember(Name = "portId")]
		public string PortId { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Flexible stacking enabled
		/// </summary>
		[DataMember(Name = "flexibleStackingEnabled")]
		public bool FlexibleStackingEnabled { get; set; }

		/// <summary>
		/// Poe enabled
		/// </summary>
		[DataMember(Name = "poeEnabled")]
		public bool PoeEnabled { get; set; }

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Vlan
		/// </summary>
		[DataMember(Name = "vlan")]
		public int Vlan { get; set; } = 0;

		/// <summary>
		/// Voice vlan
		/// </summary>
		[DataMember(Name = "voiceVlan")]
		public int VoiceVlan { get; set; } = 0;

		/// <summary>
		/// Isolation enabled
		/// </summary>
		[DataMember(Name = "isolationEnabled")]
		public bool IsolationEnabled { get; set; }

		/// <summary>
		/// Rstp enabled
		/// </summary>
		[DataMember(Name = "rstpEnabled")]
		public bool RstpEnabled { get; set; }

		/// <summary>
		/// Stp guard
		/// </summary>
		[DataMember(Name = "stpGuard")]
		public string StpGuard { get; set; } = string.Empty;

		/// <summary>
		/// Link negotiation
		/// </summary>
		[DataMember(Name = "linkNegotiation")]
		public string LinkNegotiation { get; set; } = string.Empty;

		/// <summary>
		/// Port schedule id
		/// </summary>
		[DataMember(Name = "portScheduleId")]
		public string PortScheduleId { get; set; } = string.Empty;

		/// <summary>
		/// Udld
		/// </summary>
		[DataMember(Name = "udld")]
		public string Udld { get; set; } = string.Empty;

		/// <summary>
		/// Access policy type
		/// </summary>
		[DataMember(Name = "accessPolicyType")]
		public string AccessPolicyType { get; set; } = string.Empty;

		/// <summary>
		/// Sticky MAC allow list
		/// </summary>
		[DataMember(Name = "stickyMacAllowList")]
		public List<string> StickyMacAllowList { get; set; } = new();

		/// <summary>
		/// Sticky MAC allow list limit
		/// </summary>
		[DataMember(Name = "stickyMacAllowListLimit")]
		public int StickyMacAllowListLimit { get; set; } = 0;

		/// <summary>
		/// Storm control enabled
		/// </summary>
		[DataMember(Name = "stormControlEnabled")]
		public bool StormControlEnabled { get; set; }
	}
}
