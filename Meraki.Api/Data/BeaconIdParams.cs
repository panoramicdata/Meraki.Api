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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uuid")]
	public string Uuid { get; set; } = string.Empty;

	/// <summary>
	/// Major
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "major")]
	public int Major { get; set; }

	/// <summary>
	/// Minor
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minor")]
	public int Minor { get; set; }
}
