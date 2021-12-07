namespace Meraki.Api.Data;

/// <summary>
/// Venue
/// </summary>
[DataContract]
public class Venue
{
	/// <summary>
	/// Venue name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
