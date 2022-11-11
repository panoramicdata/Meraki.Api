namespace Meraki.Api.Data;

/// <summary>
/// Configuration template
/// </summary>
[DataContract]
public class ConfigurationTemplateUpdate
{
	/// <summary>
	/// The new name of the configuration template
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The new timezone of the configuration template, for example "Europe/London".
	/// For a list of allowed timezones, please see the "TZ database name" column in
	/// the table in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
	/// </summary>
	[DataMember(Name = "timeZone")]
	public string? TimeZone { get; set; }
}
