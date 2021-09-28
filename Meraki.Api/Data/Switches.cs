using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Array of switch serial number and IP assignment. If parameter is present, it cannot have empty body. Note: switches parameter is not applicable for template networks, in other words, do not put 'switches' in the body when updating template networks. Also, an empty 'switches' array will remove all previous assignments
	/// </summary>
	[DataContract]
	public class Switches
	{
		/// <summary>
		/// Switch alternative management IP. To remove a prior IP setting, provide an empty string
		/// </summary>
		[DataMember(Name = "alternateManagementIp")]
		public string AlternateManagementIp { get; set; } = string.Empty;

		/// <summary>
		/// Switch serial number
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;
	}
}
