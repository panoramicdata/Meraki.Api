namespace Meraki.Api.Data;

/// <summary>
/// A network affected by alerts of a given type
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsOverviewByTypeItemNetwork
{
	/// <summary>
	/// Network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// Network name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
