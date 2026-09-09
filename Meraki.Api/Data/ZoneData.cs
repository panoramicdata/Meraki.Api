namespace Meraki.Api.Data;

/// <summary>
/// Zone data
/// </summary>
[DataContract]
public class ZoneData
{
	/// <summary>
	/// The number of people detected in the zone
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "person")]
	public int? Person { get; set; }
}
