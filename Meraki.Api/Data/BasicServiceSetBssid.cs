namespace Meraki.Api.Data;

/// <summary>
/// Basic service sets Bssid
/// </summary>
[DataContract]
public class BasicServiceSetBssid
{
	/// <summary>
	/// MAC Address
	/// </summary>
	[DataMember(Name = "mac_address")]
	public string MacAddress { get; set; } = string.Empty;

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool enabled { get; set; }
}
