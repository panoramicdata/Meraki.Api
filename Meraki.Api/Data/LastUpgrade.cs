namespace Meraki.Api.Data;

/// <summary>
/// Last upgrade
/// </summary>
[DataContract]
public class LastUpgrade
{
	/// <summary>
	/// Time
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// From version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fromVersion")]
	public Version FromVersion { get; set; } = new();

	/// <summary>
	/// To version
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "toVersion")]
	public Version ToVersion { get; set; } = new();
}
