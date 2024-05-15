namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings By Network Meta Counts
/// </summary>
[DataContract]
public class AirMarshalSettingsByNetworkMetaCounts
{
	/// <summary>
	/// Items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public AirMarshalSettingsByNetworkMetaCountsItems Items { get; set; } = new();

}
