namespace Meraki.Api.Data;

/// <summary>
/// Licensing
/// </summary>
[DataContract]

public class OrganizationLicensing
{
	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public string Model { get; set; } = string.Empty;
}