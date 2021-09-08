using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A configuration template
	/// </summary>
	[DataContract]
	public class ConfigurationTemplate : NamedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Readonly: ProductTypes
		/// </summary>
		[DataMember(Name = "productTypes")]
		public List<string> ProductTypes { get; set; } = new();

		/// <summary>
		/// The timezone of the configuration template.
		/// For a list of allowed timezones, please see the 'TZ' column in the table in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = string.Empty;
	}
}