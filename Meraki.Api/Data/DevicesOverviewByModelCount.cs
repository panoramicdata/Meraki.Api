namespace Meraki.Api.Data;

/// <summary>
/// Devices Overview By Model Count
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class DevicesOverviewByModelCount
{
	/// <summary>
	/// Total number of devices for the model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Device model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;
}
