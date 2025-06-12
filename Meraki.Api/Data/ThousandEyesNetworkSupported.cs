namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Supported
/// </summary>
[DataContract]
public class ThousandEyesNetworkSupported
{
	/// <summary>
	/// Name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// ID of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Network tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Network primary MX device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public ThousandEyesNetworkSupportedDevice Device { get; set; } = new();
}
