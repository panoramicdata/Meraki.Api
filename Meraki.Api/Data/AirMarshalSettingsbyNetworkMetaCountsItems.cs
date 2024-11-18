namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings By Network Meta Counts Items
/// </summary>
[DataContract]
public class AirMarshalSettingsByNetworkMetaCountsItems
{
	/// <summary>
	/// Remaining number of items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// Total number of items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
