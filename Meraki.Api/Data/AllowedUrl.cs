using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AllowedUrl
	/// </summary>
	[DataContract]
	public partial class AllowedUrl
	{
		/// <summary>
		/// The url to whitelist
		/// </summary>
		/// <value>The url to whitelist</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }
		/// <summary>
		/// Comment about the whitelisted entity
		/// </summary>
		/// <value>Comment about the whitelisted entity</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; }
	}
}
