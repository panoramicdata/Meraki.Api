namespace Meraki.Api.Data;

/// <summary>
/// Electronic Shelf Label Settings of a network
/// </summary>
public class ElectronicShelfLabelSettingsNetwork
{
	/// <summary>
	/// Turn ESL features on and off for this network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; internal set; }

	/// <summary>
	/// Desired ESL hostname of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "hostname")]
	public string Hostname { get; internal set; } = string.Empty;
}
