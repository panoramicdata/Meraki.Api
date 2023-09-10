namespace Meraki.Api.Data;

/// <summary>
/// Alert
/// </summary>
[DataContract]
public class Alert
{
	/// <summary>
	/// The type of alert
	/// </summary>
	/// <value>The type of alert</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public AlertType Type { get; set; }

	/// <summary>
	/// A boolean depicting if the alert is turned on or off
	/// </summary>
	/// <value>A boolean depicting if the alert is turned on or off</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Gets or Sets AlertDestinations
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "alertDestinations")]
	public AlertDestinations AlertDestinations { get; set; } = new();

	/// <summary>
	/// A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.
	/// </summary>
	/// <value>A hash of specific configuration data for the alert. Only filters specific to the alert will be updated.</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "filters")]
	public Dictionary<string, string> Filters { get; set; } = new();
}
