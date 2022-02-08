namespace Meraki.Api.Data;

/// <summary>
/// Next upgrade
/// </summary>
[DataContract]
public class NextUpgrade
{
	/// <summary>
	/// Time
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// To version
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "toVersion")]
	public Version ToVersion { get; set; } = new();
}
