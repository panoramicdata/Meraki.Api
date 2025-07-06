namespace Meraki.Api.Data;

/// <summary>
/// Counts Events Details 
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemCountsEvents
{
	/// <summary>
	/// Total events generated during a RADIUS session
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}