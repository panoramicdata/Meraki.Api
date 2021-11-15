namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceCellularGatewaySettingsPortForwardingRules
/// </summary>
[DataContract]
public class CellularGatewaySettingsPortForwardingRulesUpdateRequest
{
	/// <summary>
	/// An array of port forwarding params
	/// </summary>
	/// <value>An array of port forwarding params</value>
	[DataMember(Name = "rules")]
	public List<CellularGatewaySettingsPortForwardingRule> Rules { get; set; } = new();
}
