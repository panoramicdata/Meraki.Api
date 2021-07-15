using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The new fields of the device. Each field of this object is optional.
	/// </summary>
	[DataContract]
	public partial class DeviceFields
	{
		/// <summary>
		/// New name for the device
		/// </summary>
		/// <value>New name for the device</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// New notes for the device
		/// </summary>
		/// <value>New notes for the device</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; } = string.Empty;
	}
}
