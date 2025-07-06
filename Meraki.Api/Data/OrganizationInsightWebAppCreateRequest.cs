namespace Meraki.Api.Data;

/// <summary>
/// Organization Insight Web Application Create Request
/// </summary>
[DataContract]
public class OrganizationInsightWebAppCreateRequest
{
	/// <summary>
	/// The hostname of Web Application
	/// </summary>
	[DataMember(Name = "hostname")]
	public string Hostname { get; set; } = string.Empty;

	/// <summary>
	/// The name of the Web Application
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
