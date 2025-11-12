namespace Meraki.Api.Data;

/// <summary>
/// Organization Assurance Alert Scope
/// </summary>
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
	/// Other affected items by the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "others")]
	public List<string> Others { get; set; } = [];

	/// <summary>
	/// Description of affected devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<OrganizationAssuranceAlertScopeDevice> Devices { get; set; } = [];
}
