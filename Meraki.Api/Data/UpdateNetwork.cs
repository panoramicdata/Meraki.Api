using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetwork
	/// </summary>
	[DataContract]
	public partial class UpdateNetwork
	{
		/// <summary>
		/// The name of the network
		/// </summary>
		/// <value>The name of the network</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;
		/// </summary>
		/// <value>The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }
		/// <summary>
		/// A space-separated list of tags to be applied to the network
		/// </summary>
		/// <value>A space-separated list of tags to be applied to the network</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public string Tags { get; set; }
		/// <summary>
		/// Disables the local device status pages (&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://my.meraki.com/&#39;&gt;my.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://ap.meraki.com/&#39;&gt;ap.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://switch.meraki.com/&#39;&gt;switch.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://wired.meraki.com/&#39;&gt;wired.meraki.com&lt;/a&gt;). Optional (defaults to false)
		/// </summary>
		/// <value>Disables the local device status pages (&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://my.meraki.com/&#39;&gt;my.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://ap.meraki.com/&#39;&gt;ap.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://switch.meraki.com/&#39;&gt;switch.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://wired.meraki.com/&#39;&gt;wired.meraki.com&lt;/a&gt;). Optional (defaults to false)</value>
		[DataMember(Name = "disableMyMerakiCom", EmitDefaultValue = false)]
		public bool? DisableMyMerakiCom { get; set; }
		/// <summary>
		/// Disables access to the device status page (&lt;a target&#x3D;&#39;_blank&#39;&gt;http://[device&#39;s LAN IP])&lt;/a&gt;. Optional. Can only be set if disableMyMerakiCom is set to false
		/// </summary>
		/// <value>Disables access to the device status page (&lt;a target&#x3D;&#39;_blank&#39;&gt;http://[device&#39;s LAN IP])&lt;/a&gt;. Optional. Can only be set if disableMyMerakiCom is set to false</value>
		[DataMember(Name = "disableRemoteStatusPage", EmitDefaultValue = false)]
		public bool? DisableRemoteStatusPage { get; set; }
		/// <summary>
		/// A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.
		/// </summary>
		/// <value>A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.</value>
		[DataMember(Name = "enrollmentString", EmitDefaultValue = false)]
		public string EnrollmentString { get; set; }
	}
}
