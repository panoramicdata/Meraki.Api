namespace Meraki.Api.Data;

[DataContract]
public class FloorPlansAutoLocateDevices
	: ItemsResponseWithMeta<FloorPlansAutoLocateDevice>
{
	/// <summary>
	/// List Floor Plans Auto Locate Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<FloorPlansAutoLocateDevice> Items { get; set; } = [];
}
