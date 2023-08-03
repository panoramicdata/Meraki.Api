namespace Meraki.Api.Data;

/// <summary>
/// NetworkAlertSettings
/// </summary>
[DataContract]
public class NetworkAlertSettings
{
	/// <summary>
	/// Gets or Sets DefaultDestinations
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultDestinations")]
	public DefaultDestinations? DefaultDestinations { get; set; }

	/// <summary>
	/// Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.
	/// </summary>
	/// <value>Alert-specific configuration for each type. Only alerts that pertain to the network can be updated.</value>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "alerts")]
	public List<Alert>? Alerts { get; set; }

	/// <summary>
	/// Muting - Undocumented as at 2023-06-23
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "muting")]
	public NetworkAlertSettingsMuting? Muting { get; set; }
}
