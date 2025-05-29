namespace Meraki.Api.Data;

/// <summary>
/// A port associated with the given switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPort
{
	/// <summary>
	/// Unique identifier for the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// The digital optical monitoring readings for the individual port, with the most recent snapshot first
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "readings")]
	public List<OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReading> Readings { get; set; } = [];
}
