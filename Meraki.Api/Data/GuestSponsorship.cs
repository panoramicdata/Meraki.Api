namespace Meraki.Api.Data;

/// <summary>
/// Guest sponsorship
/// </summary>
[DataContract]
public class GuestSponsorship
{
	/// <summary>
	/// Duration in minutes of sponsored guest authorization. Must be between 1 and 60480 (6 weeks)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "durationInMinutes")]
	public int DurationInMinutes { get; set; }

	/// <summary>
	/// Whether or not guests can specify how much time they are requesting.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "guestCanRequestTimeframe")]
	public bool GuestCanRequestTimeframe { get; set; }
}
