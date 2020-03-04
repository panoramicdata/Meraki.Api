using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A URL object
	/// </summary>
	[DataContract]
	public class UrlObject
	{
		/// <summary>
		/// The URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}