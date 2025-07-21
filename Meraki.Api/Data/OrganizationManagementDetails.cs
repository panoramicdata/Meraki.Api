namespace Meraki.Api.Data;

/// <summary>
/// Represents the management details of an organization, including its name and associated value.
/// </summary>
[DataContract]
public class OrganizationManagementDetails
{
	/// <summary>
	/// The name of the management detail.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The value of the management detail.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}