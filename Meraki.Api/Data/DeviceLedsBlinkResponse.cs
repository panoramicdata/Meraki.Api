using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// DeviceLedsBlinkResponse
	/// </summary>
	[DataContract]
	public class DeviceLedsBlinkResponse
	{
		/// <summary>
		/// Whether the request was successfully sent to the device
		/// </summary>
		[DataMember(Name = "sentToDevice")]

		public bool SentToDevice { get; set; }
	}
}