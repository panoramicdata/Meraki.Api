namespace Meraki.Api.Data;

[DataContract]
public class FloorPlansAutoLocateStatuses
	: ItemsResponseWithMeta<FloorPlansAutoLocateStatus>
{
	/// <summary>
	/// List Floor Plans Auto Locate Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<FloorPlansAutoLocateStatus> Items { get; set; } = [];
}
