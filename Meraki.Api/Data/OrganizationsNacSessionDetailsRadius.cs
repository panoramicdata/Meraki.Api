namespace Meraki.Api.Data;

/// <summary>
/// List of RADIUS Attributes
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsRadius
{
	/// <summary>
	/// Attributes
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "attributes")]
	public OrganizationsNacSessionDetailsRadiusAttributes Attributes { get; set; } = new();
}
