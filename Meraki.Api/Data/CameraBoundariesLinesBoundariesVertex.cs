namespace Meraki.Api.Data;

/// <summary>
/// Camera Boundaries Lines Boundaries Vertex
/// </summary>
[DataContract]
public class CameraBoundariesLinesBoundariesVertex
{
	/// <summary>
	/// The vertex x coordinate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "x")]
	public double X { get; set; }

	/// <summary>
	/// The vertex y coordinate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "y")]
	public double Y { get; set; }
}
