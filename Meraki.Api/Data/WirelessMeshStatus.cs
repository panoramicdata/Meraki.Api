namespace Meraki.Api.Data;

/// <summary>
/// Mesh status
/// </summary>
[DataContract]
public class WirelessMeshStatus
{
	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Mesh route
	/// </summary>
	[DataMember(Name = "meshRoute")]
	public List<string> MeshRoute { get; set; } = [];

	/// <summary>
	/// Latest mesh performance
	/// </summary>
	[DataMember(Name = "latestMeshPerformance")]
	public LatestMeshPerformance LatestMeshPerformance { get; set; } = new();
}
