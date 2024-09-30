namespace Meraki.Api.Data;

/// <summary>
/// A switch stack member
/// </summary>
[DataContract]
public class SwitchStackMember
{
	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial	")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Role
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;
}
