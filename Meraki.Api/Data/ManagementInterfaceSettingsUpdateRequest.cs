using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkDeviceManagementInterfaceSettings
	/// </summary>
	[DataContract]
	public partial class ManagementInterfaceSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Wan1
		/// </summary>
		[DataMember(Name = "wan1", EmitDefaultValue = false)]
		public Wan Wan1 { get; set; }

		/// <summary>
		/// Gets or Sets Wan2
		/// </summary>
		[DataMember(Name = "wan2", EmitDefaultValue = false)]
		public Wan Wan2 { get; set; }
	}
}
