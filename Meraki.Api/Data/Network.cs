using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = default!;

		/// <summary>
		/// tags
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
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
		[ApiAccess(ApiAccess.ReadCreate)]
		public List<ProductType> ProductTypes { get; set; } = new();

		/// <summary>
		/// Notes
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;

		/// <summary>
		/// A unique identifier which can be used for device enrollment or
		/// easy access through the Meraki SM Registration page or the
		/// Self Service Portal. Please note that changing this field may
		/// cause existing bookmarks to break.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "enrollmentString")]
		public string? EnrollmentString { get; set; }

		/// <summary>
		/// URL
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;
	}
}