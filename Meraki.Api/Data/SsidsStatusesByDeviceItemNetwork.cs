namespace Meraki.Api.Data;

/// <summary>
/// Ssids Statuses By Device Item Network
/// </summary>
[DataContract]
public class SsidsStatusesByDeviceItemNetwork
{
	/// <summary>
	/// Unique identifier for network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
