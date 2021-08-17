using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The ids of the wireless profile to assign to the given camera
	/// </summary>
	[DataContract]
	public partial class WirelessProfilesIds
	{
		/// <summary>
		/// The id of the backup wireless profile
		/// </summary>
		[DataMember(Name = "backup")]
		public string Backup { get; set; } = string.Empty;

		/// <summary>
		/// The id of the primary wireless profile
		/// </summary>
		[DataMember(Name = "primary")]
		public string Primary { get; set; } = string.Empty;

		/// <summary>
		/// The id of the secondary wireless profile
		/// </summary>
		[DataMember(Name = "secondary")]
		public string Secondary { get; set; } = string.Empty;
	}
}
