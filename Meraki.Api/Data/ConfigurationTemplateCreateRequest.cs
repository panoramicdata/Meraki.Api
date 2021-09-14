using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Configuration template
	/// </summary>
	[DataContract]
	public class ConfigurationTemplateCreateRequest
	{
		/// <summary>
		/// The ID of the network or config template to copy configuration from
		/// </summary>
		[DataMember(Name = "copyFromNetworkId")]
		public string? CopyFromNetworkOrConfigurationTemplateId { get; set; }

		/// <summary>
		/// The name of the configuration template
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The timezone of the configuration template. For a list of allowed timezones,
		/// please see the 'TZ' column in the table in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = string.Empty;
	}
}
