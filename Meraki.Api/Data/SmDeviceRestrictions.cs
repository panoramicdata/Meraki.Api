namespace Meraki.Api.Data;

/// <summary>
/// Device restrictions
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class SmDeviceRestrictions
{
	/// <summary>
	/// Profile
	/// </summary>
	[DataMember(Name = "profile")]
	public string Profile { get; set; } = string.Empty;

	/// <summary>
	/// Restrictions
	/// </summary>
	[DataMember(Name = "restrictions")]
	public Dictionary<string, object> Restrictions { get; set; } = [];
}
