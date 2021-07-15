using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationLicense
	/// </summary>
	[DataContract]
	public partial class LicenseUpdateRequest
	{
		/// <summary>
		/// The serial number of the device to assign this license to. Set this to null to unassign the license. If a different license is already active on the device, this parameter will control queueing/dequeuing this license.
		/// </summary>
		/// <value>The serial number of the device to assign this license to. Set this to null to unassign the license. If a different license is already active on the device, this parameter will control queueing/dequeuing this license.</value>
		[DataMember(Name = "deviceSerial", EmitDefaultValue = false)]
		public string DeviceSerial { get; set; } = string.Empty;
	}
}
