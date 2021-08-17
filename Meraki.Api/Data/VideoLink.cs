using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Video link
	/// </summary>
	[DataContract]
	public class VideoLink
	{
		/// <summary>
		/// Url
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}
