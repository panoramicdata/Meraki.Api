namespace Meraki.Api.Data;

/// <summary>
/// Free access
/// </summary>
[DataContract]
public class FreeAccess
{
	/// <summary>
	/// Duration in minutes
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "durationInMinutes")]
	public int? DurationInMinutes { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
