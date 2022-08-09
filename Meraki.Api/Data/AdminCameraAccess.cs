namespace Meraki.Api.Data;
/// <summary>
/// Admin Camera Access
/// </summary>
[DataContract]

public class AdminCameraAccess
{
	/// <summary>
	/// Orgwide
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "orgWide")]
	public bool? OrgWide { get; set; }

	/// <summary>
	/// Access
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public string? Access { get; set; }

	/// <summary>
	/// id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// cameraAccess
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "cameraAccess")]
	public string? CameraAccess { get; set; }

	/// <summary>
	/// Serials
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }
}