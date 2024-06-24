namespace Meraki.Api.Data;

/// <summary>
/// Electronic Shelf Label Settings of a device
/// </summary>
public class ElectronicShelfLabelSettings
{
	/// <summary>
	/// An identifier for the device used by the ESL system
	/// </summary>
	[ApiKey]
	[DataMember(Name = "apEslId")]
	public int ApEslId { get; internal set; }

	/// <summary>
	/// Desired ESL channel for the device, or 'Auto' (case insensitive) to use the recommended channel
	/// </summary>
	[ApiForeignKey(typeof(Device))]
	[DataMember(Name = "serial")]
	public string Serial { get; internal set; } = string.Empty;

	/// <summary>
	/// Desired ESL channel for the device, or 'Auto' (case insensitive) to use the recommended channel
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "channel")]
	public string Channel { get; internal set; } = string.Empty;

	/// <summary>
	/// Turn ESL features on and off for this device
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; internal set; }

	/// <summary>
	/// Hostname of the ESL management service
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hostname")]
	public string Hostname { get; internal set; } = string.Empty;

	/// <summary>
	/// The identifier for the device's network
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; internal set; } = string.Empty;

	/// <summary>
	/// The service providing ESL functionality
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "provider")]
	public string Provider { get; internal set; } = string.Empty;
}
