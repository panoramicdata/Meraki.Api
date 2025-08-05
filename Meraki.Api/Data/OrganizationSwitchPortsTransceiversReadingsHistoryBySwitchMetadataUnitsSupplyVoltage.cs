namespace Meraki.Api.Data;

/// <summary>
/// The units for the supply voltage values
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsSupplyVoltage
{
	/// <summary>
	/// The name of the unit for supply voltage values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The symbol of the unit for supply voltage values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "symbol")]
	public string Symbol { get; set; } = string.Empty;
}