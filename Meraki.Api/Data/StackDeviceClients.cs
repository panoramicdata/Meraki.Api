namespace Meraki.Api.Data;
/// <summary>
/// Clients
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class StackDeviceClients
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public StackDeviceClientsCounts Counts { get; set; } = new();
}
