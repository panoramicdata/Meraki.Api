using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Device connectivity
	/// </summary>
	[DataContract]
	public class DeviceConnectivity
	{
		/// <summary>
		/// First seen at
		/// </summary>
		[DataMember(Name = "firstSeenAt")]
		public string FirstSeenAt { get; set; } = string.Empty;

		/// <summary>
		/// Last seen at
		/// </summary>
		[DataMember(Name = "lastSeenAt")]
		public string LastSeenAt { get; set; } = string.Empty;
	}
}
