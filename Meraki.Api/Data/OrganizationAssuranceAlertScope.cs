namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAssuranceAlertScope
{
	/// <summary>
	/// Applications affected by the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applications")]
	public List<string> Applications { get; set; } = [];

	/// <summary>
	/// Peers affected by the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "peers")]
	public List<string> Peers { get; set; } = [];

	/// <summary>
	/// Description of affected devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<OrganizationAssuranceAlertScopeDevice> Devices { get; set; } = [];
}
