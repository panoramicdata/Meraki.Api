using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkContentFiltering
	/// </summary>
	[DataContract]
	public class NetworkContentFilteringUpdateRequest
	{
		/// <summary>
		/// A whitelist of URL patterns to allow
		/// </summary>
		/// <value>A whitelist of URL patterns to allow</value>
		[DataMember(Name = "allowedUrlPatterns", EmitDefaultValue = false)]
		public List<string> AllowedUrlPatterns { get; set; } = new();
		/// <summary>
		/// A blacklist of URL patterns to block
		/// </summary>
		/// <value>A blacklist of URL patterns to block</value>
		[DataMember(Name = "blockedUrlPatterns", EmitDefaultValue = false)]
		public List<string> BlockedUrlPatterns { get; set; } = new();
		/// <summary>
		/// A list of URL categories to block
		/// </summary>
		/// <value>A list of URL categories to block</value>
		[DataMember(Name = "blockedUrlCategories", EmitDefaultValue = false)]
		public List<string> BlockedUrlCategories { get; set; } = new();
		/// <summary>
		/// Gets or Sets UrlCategoryListSize
		/// </summary>
		[DataMember(Name = "urlCategoryListSize", EmitDefaultValue = false)]
		public UrlCategoryListSize UrlCategoryListSize { get; set; }
	}
}
