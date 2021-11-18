namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationNetwork
/// </summary>
[DataContract]
public class NetworkCreationRequest
{
	/// <summary>
	/// The name of the new network
	/// </summary>
	/// <value>The name of the new network</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	/// <summary>
	/// A space-separated list of tags to be applied to the network
	/// </summary>
	/// <value>A space-separated list of tags to be applied to the network</value>
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = null!;

	/// <summary>
	/// The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;
	/// </summary>
	/// <value>The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;</value>
	[DataMember(Name = "timeZone")]
	public string TimeZone { get; set; } = null!;

	/// <summary>
	/// The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network&#39;s type exactly.
	/// </summary>
	/// <value>The ID of the network to copy configuration from. Other provided parameters will override the copied configuration, except type which must match this network&#39;s type exactly.</value>
	[DataMember(Name = "copyFromNetworkId")]
	public string CopyFromNetworkId { get; set; } = null!;

	/// <summary>
	/// The product type(s) of the new network.
	/// </summary>
	/// <value>The product type(s) of the new network.</value>
	[DataMember(Name = "productTypes")]
	public List<ProductType> ProductTypes { get; set; } = null!;

	/// <summary>
	/// Add any notes or additional information about this network here.
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }
}
