using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceDeviceBluetoothSettings
	/// </summary>
	[DataContract]
	public class DeviceBluetoothSettings
	{
		/// <summary>
		/// Desired UUID of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "uuid")]
		public string Uuid { get; set; } = string.Empty;

		/// <summary>
		/// Desired major value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "major")]
		public int? Major { get; set; }

		/// <summary>
		/// Desired minor value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "minor")]
		public int? Minor { get; set; }
	}
}
