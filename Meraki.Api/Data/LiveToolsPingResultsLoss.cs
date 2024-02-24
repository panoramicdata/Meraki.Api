namespace Meraki.Api.Data;

/// <summary>
/// Loss percentage
/// </summary>
[DataContract]
public class LiveToolsPingResultsLoss
{
	/// <summary>
	/// Percentage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}