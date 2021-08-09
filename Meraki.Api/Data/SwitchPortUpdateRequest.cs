using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceSwitchPort
	/// </summary>
	[DataContract]
	public partial class SwitchPortUpdateRequest
	{
		/// <summary>
		/// The name of the switch port
		/// </summary>
		/// <value>The name of the switch port</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The tags of the switch port
		/// </summary>
		/// <value>The tags of the switch port</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// The status of the switch port
		/// </summary>
		/// <value>The status of the switch port</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }

		/// <summary>
		/// For supported switches (e.g. MS420/MS425), whether or not the port has flexible stacking enabled.
		/// </summary>
		[DataMember(Name = "flexibleStackingEnabled")]
		public bool FlexibleStackingEnabled { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public SwitchPortType Type { get; set; }

		/// <summary>
		/// The VLAN of the switch port. A null value will clear the value set for trunk ports.
		/// </summary>
		/// <value>The VLAN of the switch port. A null value will clear the value set for trunk ports.</value>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public int? Vlan { get; set; }

		/// <summary>
		/// The voice VLAN of the switch port. Only applicable to access ports.
		/// </summary>
		/// <value>The voice VLAN of the switch port. Only applicable to access ports.</value>
		[DataMember(Name = "voiceVlan", EmitDefaultValue = false)]
		public int? VoiceVlan { get; set; }

		/// <summary>
		/// The VLANs allowed on the switch port. Only applicable to trunk ports.
		/// </summary>
		/// <value>The VLANs allowed on the switch port. Only applicable to trunk ports.</value>
		[DataMember(Name = "allowedVlans", EmitDefaultValue = false)]
		public string AllowedVlans { get; set; } = string.Empty;

		/// <summary>
		/// The PoE status of the switch port
		/// </summary>
		/// <value>The PoE status of the switch port</value>
		[DataMember(Name = "poeEnabled", EmitDefaultValue = false)]
		public bool? PoeEnabled { get; set; }

		/// <summary>
		/// The isolation status of the switch port
		/// </summary>
		/// <value>The isolation status of the switch port</value>
		[DataMember(Name = "isolationEnabled", EmitDefaultValue = false)]
		public bool? IsolationEnabled { get; set; }

		/// <summary>
		/// The rapid spanning tree protocol status
		/// </summary>
		/// <value>The rapid spanning tree protocol status</value>
		[DataMember(Name = "rstpEnabled", EmitDefaultValue = false)]
		public bool? RstpEnabled { get; set; }

		/// <summary>
		/// Gets or Sets StpGuard
		/// </summary>
		[DataMember(Name = "stpGuard", EmitDefaultValue = false)]
		public StpGuard StpGuard { get; set; }

		/// <summary>
		/// The number of the access policy of the switch port. Only applicable to access ports.
		/// </summary>
		/// <value>The number of the access policy of the switch port. Only applicable to access ports.</value>
		[DataMember(Name = "accessPolicyNumber", EmitDefaultValue = false)]
		public int? AccessPolicyNumber { get; set; }

		/// <summary>
		/// The link speed for the switch port
		/// </summary>
		/// <value>The link speed for the switch port</value>
		[DataMember(Name = "linkNegotiation", EmitDefaultValue = false)]
		public string LinkNegotiation { get; set; } = string.Empty;

		/// <summary>
		/// The ID of the port schedule. A value of null will clear the port schedule.
		/// </summary>
		/// <value>The ID of the port schedule. A value of null will clear the port schedule.</value>
		[DataMember(Name = "portScheduleId", EmitDefaultValue = false)]
		public string PortScheduleId { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Udld
		/// </summary>
		[DataMember(Name = "udld", EmitDefaultValue = false)]
		public Udld Udld { get; set; }

		/// <summary>
		/// Only devices with MAC addresses specified in this list will have access to this port. Up to 20 MAC addresses can be defined. To disable MAC whitelist, set accessPolicyNumber to null.
		/// </summary>
		/// <value>Only devices with MAC addresses specified in this list will have access to this port. Up to 20 MAC addresses can be defined. To disable MAC whitelist, set accessPolicyNumber to null.</value>
		[DataMember(Name = "macWhitelist", EmitDefaultValue = false)]
		public List<string> MacWhitelist { get; set; } = new();

		/// <summary>
		/// The initial list of MAC addresses for sticky Mac whitelist. To reset Sticky MAC whitelist, set accessPolicyNumber to null.
		/// </summary>
		/// <value>The initial list of MAC addresses for sticky Mac whitelist. To reset Sticky MAC whitelist, set accessPolicyNumber to null.</value>
		[DataMember(Name = "stickyMacWhitelist", EmitDefaultValue = false)]
		public List<string> StickyMacWhitelist { get; set; } = new();

		/// <summary>
		/// The maximum number of MAC addresses for sticky MAC whitelist.
		/// </summary>
		/// <value>The maximum number of MAC addresses for sticky MAC whitelist.</value>
		[DataMember(Name = "stickyMacWhitelistLimit", EmitDefaultValue = false)]
		public int? StickyMacWhitelistLimit { get; set; }

		/// <summary>
		/// The storm control status of the switch port
		/// </summary>
		/// <value>The storm control status of the switch port</value>
		[DataMember(Name = "stormControlEnabled", EmitDefaultValue = false)]
		public bool? StormControlEnabled { get; set; }
	}
}
