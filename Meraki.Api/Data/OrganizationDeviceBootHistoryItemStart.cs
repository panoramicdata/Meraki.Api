namespace Meraki.Api.Data;

/// <summary>
/// Device power up
/// </summary>
[DataContract]
public class OrganizationDeviceBootHistoryItemStart
{
	/// <summary>
	/// Indicates when the device booted
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "bootedAt")]
	public string BootedAt { get; set; } = string.Empty;
}
