namespace Meraki.Api.Data;

/// <summary>
/// Device Live Tools Speed Test Create Request
/// </summary>
[DataContract]
public class DeviceLiveToolsSpeedTestCreateRequest
{
	/// <summary>
	/// Optional filter for a specific WAN interface. Valid interfaces are wan1, wan2. Default will return wan1.
	/// </summary>
	[DataMember(Name = "interface")]
	public FilterInterface? Interface { get; set; }
}
