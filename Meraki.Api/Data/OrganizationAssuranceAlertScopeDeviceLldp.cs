namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertScopeDeviceLldp
{
	/// <summary>
	/// Port of affect device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

}
