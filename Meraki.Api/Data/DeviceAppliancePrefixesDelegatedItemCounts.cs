namespace Meraki.Api.Data;

/// <summary>
/// Counts
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedItemCounts
{
	/// <summary>
	/// Assigned
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assigned")]
	public int Assigned { get; set; }

	/// <summary>
	/// Available
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "available")]
	public int Available { get; set; }
}