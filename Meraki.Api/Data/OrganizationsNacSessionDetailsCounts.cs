namespace Meraki.Api.Data;

/// <summary>
/// Counts Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsCounts
{
	/// <summary>
	/// Counts Events Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "events")]
	public OrganizationsNacSessionDetailsCountsEvents Events { get; set; } = new();
}
