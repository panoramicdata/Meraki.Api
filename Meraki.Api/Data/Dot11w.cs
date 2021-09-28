using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The current setting for Protected Management Frames (802.11w).
	/// </summary>
	[DataContract]
	public class Dot11w
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Required
		/// </summary>
		[DataMember(Name = "required")]
		public bool Required { get; set; }
	}
}
