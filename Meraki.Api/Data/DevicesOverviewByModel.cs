namespace Meraki.Api.Data;

/// <summary>
/// Devices Overview By Model
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class DevicesOverviewByModel
{
	/// <summary>
	/// Counts of devices per model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public List<DevicesOverviewByModelCount>? Counts { get; set; }
}
