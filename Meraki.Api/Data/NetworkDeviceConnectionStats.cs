namespace Meraki.Api.Data;

/// <summary>
/// Network Device Connection Stats
/// </summary>
[DataContract]
public class NetworkDeviceConnectionStats
{
	/// <summary>
	/// mac
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// connectionStats
	/// </summary>
	[DataMember(Name = "connectionStats")]
	public ConnectionStats ConnectionStats { get; set; } = null!;
}
