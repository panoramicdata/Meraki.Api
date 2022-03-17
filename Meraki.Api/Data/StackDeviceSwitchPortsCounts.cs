namespace Meraki.Api.Data;
/// <summary>
/// Counts
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class StackDeviceSwitchPortsCounts
{
	/// <summary>
	/// By status
	/// </summary>
	[DataMember(Name = "byStatus")]
	public StackDeviceSwitchPortsCountsByStatus ByStatus { get; set; } = new();
}
