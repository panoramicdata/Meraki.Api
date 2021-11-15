using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Beacon ID parameters
/// </summary>
[DataContract]
public class BeaconIdParams
{
	/// <summary>
	/// UUID
	/// </summary>
	[DataMember(Name = "uuid")]
	public string Uuid { get; set; } = string.Empty;

	/// <summary>
	/// Major
	/// </summary>
	[DataMember(Name = "major")]
	public int Major { get; set; }

	/// <summary>
	/// Minor
	/// </summary>
	[DataMember(Name = "minor")]
	public int Minor { get; set; }
}
