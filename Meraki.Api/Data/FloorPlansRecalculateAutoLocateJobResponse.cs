namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Recalculate Auto Locate Job Response
/// </summary>
[DataContract]
public class FloorPlansRecalculateAutoLocateJobResponse
{
	/// <summary>
	/// Status of attempt to trigger auto locate recalculation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "success")]
	public bool Success { get; set; }
}
