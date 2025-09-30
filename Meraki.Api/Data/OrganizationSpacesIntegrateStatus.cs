namespace Meraki.Api.Data;

/// <summary>
/// Organization Spaces Integration Status
/// </summary>
[DataContract]
public class OrganizationSpacesIntegrateStatus
{
	/// <summary>
	/// The spaces dashboard account name created in spaces integration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accountName")]
	public string AccountName { get; set; } = string.Empty;

	/// <summary>
	/// The spaces dashboard account type created in spaces integration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accountType")]
	public string AccountType { get; set; } = string.Empty;

	/// <summary>
	/// The meraki user who attempts the spaces integration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// The success or failure status of the API
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public bool Status { get; set; }

	/// <summary>
	/// The set of different states on the spaces integration process
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "states")]
	public List<string> States { get; set; } = [];
}
