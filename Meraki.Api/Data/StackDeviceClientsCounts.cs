namespace Meraki.Api.Data;
/// <summary>
/// Counts
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class StackDeviceClientsCounts
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
