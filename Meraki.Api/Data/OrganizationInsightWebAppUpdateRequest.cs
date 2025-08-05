namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Web App Update Request
/// </summary>
[DataContract]
public class OrganizationInsightWebAppUpdateRequest
{
	/// <summary>
	/// The hostname of Web Application
	/// </summary>
	[DataMember(Name = "hostname")]
	public string? Hostname { get; set; }

	/// <summary>
	/// The name of the Web Application
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
