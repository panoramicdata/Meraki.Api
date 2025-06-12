namespace Meraki.Api.Data;

/// <summary>
/// Possible severity for the alert type 
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertsTaxonomyTypeSeverity
{
	/// <summary>
	/// The severity for the alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}