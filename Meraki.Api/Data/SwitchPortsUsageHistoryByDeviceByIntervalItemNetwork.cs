namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Usage History By Device By Interval Item Network
/// </summary>
[DataContract]
public class SwitchPortsUsageHistoryByDeviceByIntervalItemNetwork
{
	/// <summary>
	/// The ID of the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

}
