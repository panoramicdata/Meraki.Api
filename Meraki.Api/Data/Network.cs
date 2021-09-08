using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A network
	/// </summary>
	[DataContract]
	public class Network : NamedIdentifiedItem
	{
		public const int MaxNameLength = 38;

		/// <summary>
		/// OrganizationId
		/// </summary>
		[DataMember(Name = "organizationId")]
		public string OrganizationId { get; set; } = default!;

		/// <summary>
		/// timeZone
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = default!;

		/// <summary>
		/// tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = default!;

		/// <summary>
		/// type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = default!;

		/// <summary>
		/// disableMyMerakiCom
		/// </summary>
		[DataMember(Name = "disableMyMerakiCom")]
		public bool DisableMyMerakiCom { get; set; }

		/// <summary>
		/// disableRemoteStatusPage
		/// </summary>
		[DataMember(Name = "disableRemoteStatusPage")]
		public bool DisableRemoteStatusPage { get; set; }

		/// <summary>
		/// configTemplateId
		/// </summary>
		[DataMember(Name = "configTemplateId")]
		public string? ConfigurationTemplateId { get; set; }

		/// <summary>
		/// Product types
		/// </summary>
		[DataMember(Name = "productTypes")]
		public List<string> ProductTypes { get; set; } = new List<string>();

		/// <summary>
		/// Notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// EnrollmentString
		/// </summary>
		[DataMember(Name = "enrollmentString")]
		public string? EnrollmentString { get; set; }

		/// <summary>
		/// URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}