namespace Meraki.Api.Data;

/// <summary>
/// High Availability
/// </summary>
[DataContract]
public class HighAvailability
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Role
	/// </summary>
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;
}
