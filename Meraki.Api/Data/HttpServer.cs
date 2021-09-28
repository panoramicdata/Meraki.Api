using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// HTTP servers
	/// </summary>
	[DataContract]
	public class HttpServer : NamedIdentifiedItem
	{
		/// <summary>
		/// URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}
