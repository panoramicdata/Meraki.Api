using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganizationNetwork
	/// </summary>
	[DataContract]
	public partial class NetworkCreationRequest
	{
		/// <summary>
		/// The name of the new network
		/// </summary>
		/// <value>The name of the new network</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The type of the new network. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, or a space-separated list of those for a combined network.
		/// </summary>
		/// <value>The type of the new network. Valid types are wireless, appliance, switch, systemsManager, camera, cellularGateway, or a space-separated list of those for a combined network.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; } = null!;

		/// <summary>
		/// A space-separated list of tags to be applied to the network
		/// </summary>
		/// <value>A space-separated list of tags to be applied to the network</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public string Tags { get; set; } = null!;

		/// <summary>
		/// The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;
		/// </summary>
		/// <value>The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; } = null!;

		/// <summary>
		/// The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network&#39;s type exactly.
		/// </summary>
		/// <value>The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network&#39;s type exactly.</value>
		[DataMember(Name = "copyFromNetworkId", EmitDefaultValue = false)]
		public string CopyFromNetworkId { get; set; } = null!;

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
	}
}
