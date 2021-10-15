using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Wireless profiles
	/// </summary>
	[DataContract]
	public class CameraWirelessProfiles
	{
		/// <summary>
		/// The ids of the wireless profile to assign to the given camera
		/// </summary>
		[DataMember(Name = "ids")]
		public WirelessProfilesIds Ids { get; set; } = new();
	}
}
