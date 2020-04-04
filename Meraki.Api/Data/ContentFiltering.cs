using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The content filtering settings for your group policy
	/// </summary>
	[DataContract]
	public partial class ContentFiltering
	{
		/// <summary>
		/// Gets or Sets AllowedUrlPatterns
		/// </summary>
		[DataMember(Name = "allowedUrlPatterns", EmitDefaultValue = false)]
		public AllowedUrlPatterns AllowedUrlPatterns { get; set; }
		/// <summary>
		/// Gets or Sets BlockedUrlPatterns
		/// </summary>
		[DataMember(Name = "blockedUrlPatterns", EmitDefaultValue = false)]
		public BlockedUrlPatterns BlockedUrlPatterns { get; set; }
		/// <summary>
		/// Gets or Sets BlockedUrlCategories
		/// </summary>
		[DataMember(Name = "blockedUrlCategories", EmitDefaultValue = false)]
		public BlockedUrlCategories BlockedUrlCategories { get; set; }
	}
}
