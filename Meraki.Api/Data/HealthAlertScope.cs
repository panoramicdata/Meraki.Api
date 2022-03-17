namespace Meraki.Api.Data;

/// <summary>
/// Health alert scope
/// </summary>
[DataContract]
public class HealthAlertScope
{
	/// <summary>
	/// Devices
	/// </summary>
	[DataMember(Name = "devices")]
	public List<HealthAlertScopeDevices> Devices { get; set; } = new();

	/// <summary>
	/// Applications
	/// </summary>
	[DataMember(Name = "applications")]
	public List<ApplicationJson> Applications { get; set; } = new();

	/// <summary>
	/// Peers
	/// </summary>
	[DataMember(Name = "peers")]
	public List<HealthAlertScopePeer> Peers { get; set; } = new();
}
