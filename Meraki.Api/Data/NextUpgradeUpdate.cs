using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Pending firmware update
/// </summary>
[DataContract]
public class NextUpgradeUpdate
{
	/// <summary>
	/// Time of last successful upgrade
	/// </summary>
	[DataMember(Name = "time")]
	public string Time { get; set; } = string.Empty;

	/// <summary>
	/// To version
	/// </summary>
	[DataMember(Name = "toVersion")]
	public VersionUpdate ToVersion { get; set; } = new();
}
