namespace Meraki.Api.Data;

/// <summary>
/// /organizations
/// </summary>
[DataContract]
public class SlashOrganizations
{
	/// <summary>
	/// Get
	/// </summary>
	[DataMember(Name = "get")]
	public SlashOrganizationGet Get { get; set; } = new();
}
