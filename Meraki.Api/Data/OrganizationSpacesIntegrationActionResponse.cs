namespace Meraki.Api.Data;

/// <summary>
/// Organization Spaces Integration Action Response
/// </summary>
[DataContract]
public class OrganizationSpacesIntegrationActionResponse
{
	/// <summary>
	/// The error message of the API
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// The success or failure status of the API
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public bool Status { get; set; }
}
