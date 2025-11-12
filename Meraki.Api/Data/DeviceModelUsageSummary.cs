namespace Meraki.Api.Data;

/// <summary>
/// Device Model Usage Summary
/// </summary>
[DataContract]
public class DeviceModelUsageSummary
{
	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Count
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>
	/// Usage
	/// </summary>
	[DataMember(Name = "usage")]
	public DeviceModelUsageSummaryUsage Usage { get; set; } = new();
}
