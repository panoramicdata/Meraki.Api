namespace Meraki.Api.Data;

/// <summary>
/// Configuration settings for port profile
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfilePort
{
	/// <summary>
	/// The number of a custom access policy to configure on the port profile. Only applicable when 'accessPolicyType' is 'Custom access policy'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accessPolicyNumber")]
	public int? AccessPolicyNumber { get; set; }

	/// <summary>
	/// The maximum number of MAC addresses for sticky MAC allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "stickyMacAllowListLimit")]
	public int? StickyMacAllowListLimit { get; set; }

	/// <summary>
	/// The VLAN of the port profile. A null value will clear the value set for trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// The voice VLAN of the port profile. Only applicable to access ports.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "voiceVlan")]
	public int? VoiceVlan { get; set; }

	/// <summary>
	/// The type of the access policy of the port profile. Only applicable to access ports.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accessPolicyType")]
	public AccessPolicyType? AccessPolicyType { get; set; }

	/// <summary>
	/// The adaptive policy group ID that will be used to tag traffic through this port profile. This ID must pre-exist during the configuration, else needs to be created using adaptivePolicy/groups API.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accessPolicyGroupId")]
	public string? AdaptivePolicyGroupId { get; set; }

	/// <summary>
	/// The VLANs allowed on the port profile. Only applicable to trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// The state of the STP guard.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "stpGuard")]
	public StpGuard? StpGuard { get; set; }

	/// <summary>
	/// The type of the port profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// The action to take when Unidirectional Link is detected. LinkDefault configuration is Alert only.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "udld")]
	public Udld? Udld { get; set; }

	/// <summary>
	/// If true, ARP packets for this port will be considered trusted, and Dynamic ARP Inspection will allow the traffic.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "daiTrusted")]
	public bool? DaiTrusted { get; set; }

	/// <summary>
	/// The isolation status of the port profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isolationEnabled")]
	public bool? IsolationEnabled { get; set; }

	/// <summary>
	/// If true, Peer SGT is enabled for traffic through this port profile.Applicable to trunk ports only
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "peerSgtCapable")]
	public bool? PeerSgtCapable { get; set; }

	/// <summary>
	/// The PoE status of the port profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "poeEnabled")]
	public bool? PoeEnabled { get; set; }

	/// <summary>
	/// The rapid spanning tree protocol status.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "rstpEnabled")]
	public bool? RstpEnabled { get; set; }

	/// <summary>
	/// The storm control status of the port profile.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "stormControlEnabled")]
	public bool? StormControlEnabled { get; set; }

	/// <summary>
	/// Only devices with MAC addresses specified in this list will have access to this port. Up to 20 MAC addresses can be defined. Only applicable when 'accessPolicyType' is 'MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "macAllowList")]
	public List<string>? MacAllowList { get; set; }

	/// <summary>
	/// The initial list of MAC addresses for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "stickyMacAllowList")]
	public List<string>? StickyMacAllowList { get; set; }
}