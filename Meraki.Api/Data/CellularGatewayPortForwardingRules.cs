namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceCellularGatewaySettingsPortForwardingRules
/// </summary>
[DataContract]
public class CellularGatewayPortForwardingRules
{
	/// <summary>
	/// An array of port forwarding params
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<CellularGatewayPortForwardingRule> Rules { get; set; } = new();
}
