namespace Meraki.Api.Data;

/// <summary>
/// Object for Total RADIUS Sessions
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryMetadataCounts
{
	/// <summary>
	/// Object for Total RADIUS Sessions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationsNacSessionsHistoryMetadataCountsItems Items { get; set; } = new();
}
