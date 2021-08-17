using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// HTTP servers
	/// </summary>
	[DataContract]
	public class HttpServers
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}
