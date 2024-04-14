namespace Meraki.Api.Data;

/// <summary>
/// Camera Boundaries Areas Boundaries
/// </summary>
[DataContract]
public class CameraBoundariesLinesBoundaries
{
	/// <summary>
	/// The line boundary id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiKey]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The area boundary name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The area boundary type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The line boundary crossing direction vertex
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "directionVertex")]
	public CameraBoundariesLinesBoundariesDirectionVertex DirectionVertex { get; set; } = new();

	/// <summary>
	/// The line boundary vertices
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vertices")]
	public List<CameraBoundariesLinesBoundariesVertex> Vertices { get; set; } = [];
}
