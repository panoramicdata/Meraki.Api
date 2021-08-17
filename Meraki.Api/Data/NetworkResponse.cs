using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Response
	/// </summary>
	[DataContract]
	public class NetworkResponse
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Organization id
		/// </summary>
		[DataMember(Name = "organizationId")]
		public string OrganizationId { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Time zone
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// Product types
		/// </summary>
		[DataMember(Name = "productTypes")]
		public List<string> ProductTypes { get; set; } = new();

		/// <summary>
		/// Enrollment string
		/// </summary>
		[DataMember(Name = "enrollmentString")]
		public string EnrollmentString { get; set; } = string.Empty;

		/// <summary>
		/// Notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;
	}
}
