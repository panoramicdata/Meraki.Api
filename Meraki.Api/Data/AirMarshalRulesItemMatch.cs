namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Rules Item Match
/// </summary>
[DataContract]
public class AirMarshalRulesItemMatch
{
	/// <summary>
	/// Indicates whether or not clients are allowed to connect to rogue SSIDs by default. (blocked by default)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "string")]
	public string MatchString { get; set; } = string.Empty;

	/// <summary>
	/// Indicates whether or not clients are allowed to connect to rogue SSIDs by default. (blocked by default)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
