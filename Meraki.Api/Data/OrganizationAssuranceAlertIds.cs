namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertIds
{
	/// <summary>
	/// Parameter to restore alerts by ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "alertIds")]
	public List<string> AlertIds { get; set; } = [];

}
