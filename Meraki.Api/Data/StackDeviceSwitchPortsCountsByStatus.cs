namespace Meraki.Api.Data;
/// <summary>
/// By status
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class StackDeviceSwitchPortsCountsByStatus
{
	/// <summary>
	/// Active
	/// </summary>
	[DataMember(Name = "active")]
	public string Active { get; set; } = string.Empty;
}
