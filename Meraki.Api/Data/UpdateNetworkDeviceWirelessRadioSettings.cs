using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkDeviceWirelessRadioSettings
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkDeviceWirelessRadioSettings
	{
		/// <summary>
		/// The ID of an RF profile to assign to the device. If the value of this parameter is null, the appropriate basic RF profile     (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually configured overrides     on the device (channel width, channel, power).
		/// </summary>
		/// <value>The ID of an RF profile to assign to the device. If the value of this parameter is null, the appropriate basic RF profile     (indoor or outdoor) will be assigned to the device. Assigning an RF profile will clear ALL manually configured overrides     on the device (channel width, channel, power).</value>
		[DataMember(Name = "rfProfileId", EmitDefaultValue = false)]
		public int? RfProfileId { get; set; }
	}
}
