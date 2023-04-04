namespace Meraki.Api.Data;

[DataContract]
public abstract class NetworkOrConfigurationTemplate : NamedIdentifiedItem
{
	/// <summary>
	/// The timezone of the configuration template.
	/// For a list of allowed timezones, please see the 'TZ' column in the table in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
	/// </summary>
	[DataMember(Name = "timeZone")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string TimeZone { get; set; } = string.Empty;

	/// <summary>
	/// Product Types
	/// Implemented with different API AccessLevels by parents
	/// </summary>
	[ApiForeignKey(typeof(ProductType))]
	public abstract List<ProductType> ProductTypes { get; set; }
}
