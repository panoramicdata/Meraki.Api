namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item Network
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SsidsStatusesByDeviceItemNetwork
{
	/// <summary>
	/// Unique identifier for network.
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of network.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
