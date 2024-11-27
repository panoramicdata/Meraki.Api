namespace Meraki.Api.Data;

[DataContract]
public class FloorPlansAutoLocateDevices
	: ItemsResponseMeta<FloorPlansAutoLocateDevice>
{
	/// <summary>
	/// List Floor Plamns Auto Locate Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public override List<FloorPlansAutoLocateDevice> Items { get; set; } = [];
}
