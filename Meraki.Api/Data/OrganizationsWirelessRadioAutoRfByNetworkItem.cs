namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio Auto RF By Network Item
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkItem
{
	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Id of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Time zone of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "timezone")]
	public string TimeZone { get; set; } = string.Empty;

	/// <summary>
	/// AI-RRM settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "aiRrm")]
	public OrganizationsWirelessRadioAutoRfByNetworkAiRrm AiRrm { get; set; } = new();

	/// <summary>
	/// Busy Hour settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "busyHour")]
	public OrganizationsWirelessRadioAutoRfByNetworkBusyHour BusyHour { get; set; } = new();

	/// <summary>
	/// Channel settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "channel")]
	public OrganizationsWirelessRadioAutoRfByNetworkChannel Channel { get; set; } = new();

	/// <summary>
	/// FRA settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fra")]
	public OrganizationWirelessDevicesLatencyByNetworkFra Fra { get; set; } = new();
}
