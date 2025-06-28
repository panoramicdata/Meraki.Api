namespace Meraki.Api.Data;

/// <summary>
/// RADIUS Attribute
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsRadiusAttributesInformation
{
	/// <summary>
	/// Attribute Code
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "code")]
	public string Code { get; set; } = string.Empty;

	/// <summary>
	/// Attribute Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Attribute Value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}