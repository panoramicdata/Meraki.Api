namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alert Network
/// </summary>
[DataContract]
public class OrganizationAssuranceAlertNetwork : NamedIdentifiedItem
{
	/// <summary>
	/// Dashboard URL for the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
