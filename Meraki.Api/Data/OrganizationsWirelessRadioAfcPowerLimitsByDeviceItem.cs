namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio AFC Power Limits By Device Item
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAfcPowerLimitsByDeviceItem
{
	/// <summary>
	/// Expiration date of power limits table.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty;

	/// <summary>
	/// Time of last AFC successful fetch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastSuccessAt")]
	public string LastSuccessAt { get; set; } = string.Empty;

	/// <summary>
	/// Time of last AFC fetch.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lastUpdatedAt")]
	public string LastUpdatedAt { get; set; } = string.Empty;

	/// <summary>
	/// Name of device
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Serial of device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Status of AFC response
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Location attributes of device's AFC information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "location")]
	public OrganizationsWirelessRadioAfcPowerLimitsByDeviceLocation Location { get; set; } = new();

	/// <summary>
	/// Network of device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationsWirelessRadioAfcByDeviceNetwork Network { get; set; } = new();

	/// <summary>
	/// Power limits of each 6 GHz channel.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byChannel")]
	public List<OrganizationsWirelessRadioAfcPowerLimitsByDeviceByChannelItem> ByChannel { get; set; } = [];
}
