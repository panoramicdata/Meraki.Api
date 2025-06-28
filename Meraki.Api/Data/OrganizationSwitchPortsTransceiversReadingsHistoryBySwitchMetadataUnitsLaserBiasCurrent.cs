namespace Meraki.Api.Data;

/// <summary>
/// The units for the laser bias current values
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsLaserBiasCurrent
{
	/// <summary>
	/// The name of the unit for laser bias current values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The symbol of the unit for laser bias current values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "symbol")]
	public string Symbol { get; set; } = string.Empty;
}