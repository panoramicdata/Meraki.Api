namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Profile attributes
/// </summary>
[DataContract]
public class SwitchPortsProfilePort
{
	/// <summary>
	/// The number of a custom access policy to configure on the switch port profile. Only applicable when 'accessPolicyType' is 'Custom access policy'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "accessPolicyNumber")]
	public int? AccessPolicyNumber { get; set; }

	/// <summary>
	/// The maximum number of MAC addresses for sticky MAC allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stickMacAllowListLimit")]
	public int? StickMacAllowListLimit { get; set; }

	/// <summary>
	/// The VLAN of the switch port profile. A null value will clear the value set for trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// The voice VLAN of the switch port profile. Only applicable to access ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voiceVlan")]
	public int? VoiceVlan { get; set; }

	/// <summary>
	/// The type of the access policy of the switch port profile. Only applicable to access ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessPolicyType")]
	public string? AccssPolicyType { get; set; }

	/// <summary>
	/// The adaptive policy group ID that will be used to tag traffic through this switch port profile. This ID must pre-exist during the configuration, else needs to be created using adaptivePolicy/groups API.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adaptivePolicyGroupId")]
	public string? AdaptivePolicyGroupId { get; set; }

	/// <summary>
	///The VLANs allowed on the switch port profile. Only applicable to trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "allowedVlans")]
	public string? allowedVlans { get; set; }

	/// <summary>
	/// The link speed for the switch port profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "linkNegotiation")]
	public string? LinkNegotiation { get; set; }

	/// <summary>
	/// The ID of the port schedule. A value of null will clear the port schedule.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portScheduleId")]
	public string? PortScheduleId { get; set; }

	/// <summary>
	/// The state of the STP guard.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stpGuard")]
	public string? StpGuard { get; set; }

	/// <summary>
	/// The type of the switch port profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// The action to take when Unidirectional Link is detected. LinkDefault configuration is Alert only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "udld")]
	public string? Udld { get; set; }

	/// <summary>
	/// The isolation status of the switch port profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isolationEnabled")]
	public bool IsolationEnabled { get; set; }

	/// <summary>
	/// If true, Peer SGT is enabled for traffic through this switch port profile. Applicable to trunk ports only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peerSgtCapable")]
	public bool PeerSgtCapable { get; set; }

	/// <summary>
	///The PoE status of the switch port profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "poeEnabled")]
	public bool PoeEnabled { get; set; }

	/// <summary>
	/// The rapid spanning tree protocol status.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rstpEnabled")]
	public bool RstpEnabled { get; set; }

	/// <summary>
	/// The storm control status of the switch port profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stormControlEnabled")]
	public bool StormControlEnabled { get; set; }

	/// <summary>
	/// List of link negotiation options that are valid for the port profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "linkNegotiationCapabilities")]
	public List<string>? LinkNegotiationCapabilities { get; set; }

	/// <summary>
	/// Only devices with MAC addresses specified in this list will have access to this port. Up to 20 MAC addresses can be defined. Only applicable when 'accessPolicyType' is 'MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "macAllowList")]
	public List<string>? MacAllowList { get; set; }

	/// <summary>
	/// The initial list of MAC addresses for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "stickyMacAllowList")]
	public List<string>? StickyMacAllowList { get; set; }
}
