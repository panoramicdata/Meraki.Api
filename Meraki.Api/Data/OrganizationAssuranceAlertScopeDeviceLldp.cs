namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alert Scope Device Lldp
/// </summary>
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
