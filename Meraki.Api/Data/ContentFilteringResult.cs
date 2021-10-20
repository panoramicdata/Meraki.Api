using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The content filtering settings for your group policy
	/// </summary>
	[DataContract]
	public class ContentFilteringResult
	{
		/// <summary>
		/// Gets or Sets UrlCategoryListSize
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "urlCategoryListSize")]
		public UrlCategoryListSize UrlCategoryListSize { get; set; }

		/// <summary>
		/// Gets or Sets AllowedUrlPatterns
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "allowedUrlPatterns")]
		public List<string> AllowedUrlPatterns { get; set; } = new();

		/// <summary>
		/// Gets or Sets BlockedUrlPatterns
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "blockedUrlPatterns")]
		public List<string> BlockedUrlPatterns { get; set; } = new();

		/// <summary>
		/// Gets or Sets BlockedUrlCategories
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "blockedUrlCategories")]
		public List<ContentFilteringCategory> BlockedUrlCategories { get; set; } = new();
	}
}
