using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkDeviceManagementInterfaceSettings
	/// </summary>
	[DataContract]
	public class ManagementInterfaceSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Wan1
		/// </summary>
		[DataMember(Name = "wan1", EmitDefaultValue = false)]
		public Wan Wan1 { get; set; } = new();

		/// <summary>
		/// Gets or Sets Wan2
		/// </summary>
		[DataMember(Name = "wan2", EmitDefaultValue = false)]
		public Wan Wan2 { get; set; } = new();
	}
}
