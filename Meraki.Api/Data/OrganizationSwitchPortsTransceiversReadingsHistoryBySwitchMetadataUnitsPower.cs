namespace Meraki.Api.Data;

/// <summary>
/// The units for the transmit and receive power values
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsPower
{
	/// <summary>
	/// The name of the unit for transmit and receive power values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The symbol of the unit for transmit and receive power values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "symbol")]
	public string Symbol { get; set; } = string.Empty;
}