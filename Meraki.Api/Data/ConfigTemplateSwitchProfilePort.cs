namespace Meraki.Api.Data;

/// <summary>
/// Switch profile port
/// </summary>
[DataContract]
public class ConfigTemplateSwitchProfilePort : NamedItem
{
	/// <summary>
	/// Port Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// The list of tags of the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = new();

	/// <summary>
	/// The status of the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// For supported switches (e.g. MS420/MS425), whether or not the port has flexible stacking enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "flexibleStackingEnabled")]
	public bool? FlexibleStackingEnabled { get; set; }

	/// <summary>
	/// The PoE status of the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "poeEnabled")]
	public bool PoeEnabled { get; set; }

	/// <summary>
	/// The type of the switch profile port ('trunk' or 'access')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public SwitchPortType Type { get; set; }

	/// <summary>
	/// The VLAN of the switch profile port. A null value will clear the value set for trunk ports.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// The voice VLAN of the switch profile port. Only applicable to access ports
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "voiceVlan")]
	public int? VoiceVlan { get; set; }

	/// <summary>
	/// The isolation status of the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "isolationEnabled")]
	public bool IsolationEnabled { get; set; }

	/// <summary>
	/// The rapid spanning tree protocol status
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rstpEnabled")]
	public bool RstpEnabled { get; set; }

	/// <summary>
	/// The state of the STP guard ('disabled', 'root guard', 'bpdu guard' or 'loop guard')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stpGuard")]
	public StpGuard StpGuard { get; set; }

	/// <summary>
	/// The link speed for the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "linkNegotiation")]
	public string LinkNegotiation { get; set; } = string.Empty;

	/// <summary>
	/// The ID of the port schedule. A value of null will clear the port schedule.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "portScheduleId")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string? PortScheduleId { get; set; }

	/// <summary>
	/// The action to take when Unidirectional Link is detected (Alert only, Enforce). Default configuration is Alert only.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "udld")]
	public Udld Udld { get; set; }

	/// <summary>
	/// The type of the access policy of the switch profile port. Only applicable to access ports. Can be one of 'Open', 'Custom access policy', 'MAC allow list' or 'Sticky MAC allow list'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "accessPolicyType")]
	public AccessPolicyType? AccessPolicyType { get; set; }

	/// <summary>
	/// The initial list of MAC addresses for sticky Mac allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stickyMacAllowList")]
	public List<string>? StickyMacAllowList { get; set; }

	/// <summary>
	/// The maximum number of MAC addresses for sticky MAC allow list. Only applicable when 'accessPolicyType' is 'Sticky MAC allow list'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stickyMacAllowListLimit")]
	public int? StickyMacAllowListLimit { get; set; }

	/// <summary>
	/// The storm control status of the switch profile port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "stormControlEnabled")]
	public bool? StormControlEnabled { get; set; }

	/// <summary>
	/// The VLANs allowed on the switch profile port. Only applicable to trunk ports
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }
}
