namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings By Network Meta
/// </summary>
[DataContract]
public class AirMarshalSettingsByNetworkMeta
{
	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public AirMarshalSettingsByNetworkMetaCounts Counts { get; set; } = new();

}
