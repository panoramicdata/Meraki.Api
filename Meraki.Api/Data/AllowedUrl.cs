using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AllowedUrl
	/// </summary>
	[DataContract]
	public class AllowedUrl
	{
		/// <summary>
		/// The url to whitelist
		/// </summary>
		/// <value>The url to whitelist</value>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
		/// <summary>
		/// Comment about the whitelisted entity
		/// </summary>
		/// <value>Comment about the whitelisted entity</value>
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = string.Empty;
	}
}
