namespace Meraki.Api.Data;
/// <summary>
/// A Device
/// </summary>
[DataContract]

public class DeviceBleParams
{
	/// <summary>
	/// uuid
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "uuid")]
	public string? Uuid { get; set; }

	/// <summary>
	/// major
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "major")]
	public int? Major { get; set; }
}