namespace Meraki.Api.Data;

/// <summary>
/// Camera
/// </summary>
[DataContract]
public class Camera
{
	/// <summary>
	/// Current version
	/// </summary>
	[DataMember(Name = "currentVersion")]
	public Version CurrentVersion { get; set; } = new();

	/// <summary>
	/// Last upgrade
	/// </summary>
	[DataMember(Name = "lastUpgrade")]
	public LastUpgrade LastUpgrade { get; set; } = new();

	/// <summary>
	/// Next upgrade
	/// </summary>
	[DataMember(Name = "nextUpgrade")]
	public NextUpgrade NextUpgrade { get; set; } = new();

	/// <summary>
	/// Available versions
	/// </summary>
	[DataMember(Name = "availableVersions")]
	public List<Version> AvailableVersions { get; set; } = [];
}
