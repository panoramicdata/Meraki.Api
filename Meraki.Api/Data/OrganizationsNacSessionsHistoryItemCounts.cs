namespace Meraki.Api.Data;

/// <summary>
/// Counts Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryItemCounts
{
	/// <summary>
	/// Counts Events Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "events")]
	public OrganizationsNacSessionsHistoryItemCountsEvents Events { get; set; } = new();
}
