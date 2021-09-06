using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The content filtering settings for your group policy
	/// </summary>
	[DataContract]
	public class ContentFiltering
	{
		/// <summary>
		/// Gets or Sets AllowedUrlPatterns
		/// </summary>
		[DataMember(Name = "allowedUrlPatterns")]
		public AllowedUrlPatterns AllowedUrlPatterns { get; set; } = new();
		/// <summary>
		/// Gets or Sets BlockedUrlPatterns
		/// </summary>
		[DataMember(Name = "blockedUrlPatterns")]
		public BlockedUrlPatterns BlockedUrlPatterns { get; set; } = new();
		/// <summary>
		/// Gets or Sets BlockedUrlCategories
		/// </summary>
		[DataMember(Name = "blockedUrlCategories")]
		public BlockedUrlCategories BlockedUrlCategories { get; set; } = new();
	}
}
