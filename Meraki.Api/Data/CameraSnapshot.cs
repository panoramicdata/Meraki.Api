using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A camera snapshot
	/// </summary>
	[DataContract]
	public class CameraSnapshot
	{
		/// <summary>
		/// Url
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;

		/// <summary>
		/// Expiry
		/// </summary>
		[DataMember(Name = "expiry")]
		public string Expiry { get; set; } = string.Empty;
	}

}