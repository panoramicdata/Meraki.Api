namespace Meraki.Api.Data;

/// <summary>
/// Port profile attributes
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfilePort
{
	/// <summary>
	/// The type of the port profile.
	/// </summary>
	[DataMember(Name = "type")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public NetworksSwitchPortsProfilePortType? Type { get; set; }

	/// <summary>
	/// The VLAN of the port profile. A null value will clear the value set for trunk ports.
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public int? Vlan { get; set; }

	/// <summary>
	/// The voice VLAN of the port profile. Only applicable to access ports.
	/// </summary>
	[DataMember(Name = "voiceVlan")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public int? VoiceVlan { get; set; }

	/// <summary>
	/// The VLANs allowed on the port profile. Only applicable to trunk ports.
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// The PoE status of the port profile.
	/// </summary>
	[DataMember(Name = "poeEnabled")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? PoeEnabled { get; set; }

	/// <summary>
	/// The isolation status of the port profile.
	/// </summary>
	[DataMember(Name = "isolationEnabled")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? IsolationEnabled { get; set; }

	/// <summary>
	/// The rapid spanning tree protocol status.
	/// </summary>
	[DataMember(Name = "rstpEnabled")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? RstpEnabled { get; set; }

	/// <summary>
	/// The state of the STP guard.
	/// </summary>
	[DataMember(Name = "stpGuard")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public NetworksSwitchPortsProfilePortStpGuard? StpGuard { get; set; }

	/// <summary>
	/// The action to take when Unidirectional Link is detected. LinkDefault configuration is Alert only.
	/// </summary>
	[DataMember(Name = "udld")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public NetworksSwitchPortsProfilePortUdld? Udld { get; set; }

	/// <summary>
	/// The number of a custom access policy to configure on the port profile. Only applicable when 'accessPolicyType' is 'Custom access policy'.
	/// </summary>
	[DataMember(Name = "accessPolicyType")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? AccessPolicyType { get; set; }

	/// <summary>
	/// The type of the access policy of the port profile. Only applicable to access ports.
	/// </summary>
	[DataMember(Name = "accessPolicyNumber")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public NetworksSwitchPortsProfilePortAccessPolicyNumber? AccessPolicyNumber { get; set; }

	/// <summary>
	/// Only devices with MAC addresses specified in this list will have access to this port. Up to 20 MAC addresses can be defined. Only applicable when 'accessPolicyType' is 'MAC allow list'.
	/// </summary>
	[DataMember(Name = "macAllowList")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public List<string>? MacAllowList { get; set; }

	/// <summary>
	/// The initial list of MAC addresses for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[DataMember(Name = "stickyMacAllowList")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public List<string>? StickyMacAllowList { get; set; }

	/// <summary>
	/// The maximum number of MAC addresses for sticky MAC allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[DataMember(Name = "stickyMacAllowListLimit")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public int? StickyMacAllowListLimit { get; set; }

	/// <summary>
	/// The storm control status of the port profile.
	/// </summary>
	[DataMember(Name = "stormControlEnabled")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? StormControlEnabled { get; set; }

	/// <summary>
	/// The adaptive policy group ID that will be used to tag traffic through this port profile. This ID must pre-exist during the configuration, else needs to be created using adaptivePolicy/groups API.
	/// </summary>
	[DataMember(Name = "adaptivePolicyGroupId")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public string? AdaptivePolicyGroupId { get; set; }

	/// <summary>
	/// If true, Peer SGT is enabled for traffic through this port profile. Applicable to trunk ports only.
	/// </summary>
	[DataMember(Name = "peerSgtCapable")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? PeerSgtCapable { get; set; }

	/// <summary>
	/// If true, ARP packets for this port will be considered trusted, and Dynamic ARP Inspection will allow the traffic.
	/// </summary>
	[DataMember(Name = "daiTrusted")]
	[ApiAccess(ApiAccess.ReadCreate)]
	public bool? DaiTrusted { get; set; }
}
