namespace Meraki.Api.Data;

/// <summary>
/// Organziation Camera Permission
/// </summary>
[DataContract]
public class OrganizationCameraPermission
{
	/// <summary>
	/// Permission scope id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Permission scope level
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public string Level { get; set; } = string.Empty;

	/// <summary>
	/// Name of permission scope
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
