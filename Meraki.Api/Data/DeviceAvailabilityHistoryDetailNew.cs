namespace Meraki.Api.Data;
/// <summary>
/// Details about the new status
/// </summary>
[DataContract]

public class DeviceAvailabilityHistoryDetailNew
{
	/// <summary>
	/// Name of the detail
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Value of the detail
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string? Value { get; set; }
}