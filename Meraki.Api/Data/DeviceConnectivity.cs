namespace Meraki.Api.Data;

/// <summary>
/// Device connectivity
/// </summary>
[DataContract]
public class DeviceConnectivity
{
	/// <summary>
	/// First seen at
	/// </summary>
	[DataMember(Name = "firstSeenAt")]
	public DateTime FirstSeenAt { get; set; }

	/// <summary>
	/// Last seen at
	/// </summary>
	[DataMember(Name = "lastSeenAt")]
	public DateTime LastSeenAt { get; set; }
}
