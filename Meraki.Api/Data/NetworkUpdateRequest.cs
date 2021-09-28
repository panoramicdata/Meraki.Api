using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetwork
	/// </summary>
	[DataContract]
	public class NetworkUpdateRequest
	{
		/// <summary>
		/// The name of the network
		/// </summary>
		/// <value>The name of the network</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;
		/// </summary>
		/// <value>The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;</value>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = string.Empty;

		/// <summary>
		/// A space-separated list of tags to be applied to the network
		/// </summary>
		/// <value>A space-separated list of tags to be applied to the network</value>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.
		/// </summary>
		/// <value>A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.</value>
		[DataMember(Name = "enrollmentString")]
		public string? EnrollmentString { get; set; }

		/// <summary>
		/// Add any notes or additional information about this network here.
		/// </summary>
		[DataMember(Name = "notes")]
		public string? Notes { get; set; }
	}
}
