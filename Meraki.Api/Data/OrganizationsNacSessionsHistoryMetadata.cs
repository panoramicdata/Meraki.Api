namespace Meraki.Api.Data;

/// <summary>
/// RADIUS Sessions metadata
/// </summary>
[DataContract]
public class OrganizationsNacSessionsHistoryMetadata
{
	/// <summary>
	/// Metadata object for RADIUS session counting
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationsNacSessionsHistoryMetadataCounts Counts { get; set; } = new();
}
