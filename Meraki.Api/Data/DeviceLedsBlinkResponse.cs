using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// BlinkNetworkDeviceLeds response showing what was actually used
	/// </summary>
	[DataContract]
	public class DeviceLedsBlinkResponse : DeviceLedsBlinkRequest
	{
	}
}