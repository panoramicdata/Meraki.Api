namespace Meraki.Api.Data;

/// <summary>
/// Organization Device Boot History Item
/// </summary>
[DataContract]
public class OrganizationDeviceBootHistoryItem
{
	/// <summary>
	/// Device serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Device network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationDeviceBootHistoryItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Device power up
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "start")]
	public OrganizationDeviceBootHistoryItemStart Start { get; set; } = new();
}
