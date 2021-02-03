using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// DeviceManagementInterfaceSettings
	/// </summary>
	[DataContract]
	public class DeviceManagementInterfaceSettings
	{
		/// <summary>
		/// Whether the request was successfully sent to the device
		/// </summary>
		[DataMember(Name = "ddnsHostnames")]
		public DeviceManagementInterfaceSettingsDdnsHostNames DdnsHostnames { get; set; }

		/// <summary>
		/// Whether the request was successfully sent to the device
		/// </summary>
		[DataMember(Name = "wan1")]
		public DeviceManagementInterfaceSettingsWan Wan1 { get; set; }

		/// <summary>
		/// Whether the request was successfully sent to the device
		/// </summary>
		[DataMember(Name = "wan2")]
		public DeviceManagementInterfaceSettingsWan Wan2 { get; set; }
	}
}