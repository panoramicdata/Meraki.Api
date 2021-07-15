using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// DeviceManagementInterfaceSettingsDdnsHostNames
	/// </summary>
	[DataContract]
	public class DeviceManagementInterfaceSettingsDdnsHostNames
	{
		/// <summary>
		/// The active DDNS hostname
		/// </summary>
		[DataMember(Name = "activeDdnsHostname")]
		public string ActiveDdnsHostname { get; set; } = string.Empty;

		/// <summary>
		/// DDNS hostname Wan1
		/// </summary>
		[DataMember(Name = "ddnsHostnameWan1")]
		public string DdnsHostnameWan1 { get; set; } = string.Empty;

		/// <summary>
		/// DDNS hostname Wan2
		/// </summary>
		[DataMember(Name = "ddnsHostnameWan2")]
		public string DdnsHostnameWan2 { get; set; } = string.Empty;
	}
}