using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Meraki.Api.Data
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProductType
	{
		[EnumMember(Value = "wireless")]
		Wireless = 1,

		[EnumMember(Value = "appliance")]
		Appliance,

		[EnumMember(Value = "switch")]
		Switch,

		[EnumMember(Value = "systemsManager")]
		SystemsManager,

		[EnumMember(Value = "camera")]
		Camera,

		[EnumMember(Value = "cellularGateway")]
		CellularGateway,

		[EnumMember(Value = "sensor")]
		Sensor,

		[EnumMember(Value = "environmental")]
		Environmental
	}
}