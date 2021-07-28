using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Configuration template
	/// </summary>
	[DataContract]
	public class ConfigurationTemplateUpdate
	{
		/// <summary>
		/// The name of the configuration template
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The timezone of the configuration template. For a list of allowed timezones, please see the 'TZ' column in the table in <a target='_blank' href='https://en.wikipedia.org/wiki/List_of_tz_database_time_zones'>this article.</a>
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = string.Empty;
	}
}
