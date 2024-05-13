namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertScopeDeviceLldp
{
	/// <summary>
	/// Port of affect device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "Port")]
	public string Port { get; set; } = string.Empty;

}
