using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationAdmin
	/// </summary>
	[DataContract]
	public class AdminUpdateRequest
	{
		/// <summary>
		/// The name of the dashboard administrator
		/// </summary>
		/// <value>The name of the dashboard administrator</value>
		[DataMember(Name = "name")]
		public string? Name { get; set; }
		/// <summary>
		/// Gets or Sets OrgAccess
		/// </summary>
		[DataMember(Name = "orgAccess")]
		public OrgAccess OrgAccess { get; set; }
		/// <summary>
		/// The list of tags that the dashboard administrator has privileges on
		/// </summary>
		/// <value>The list of tags that the dashboard administrator has privileges on</value>
		[DataMember(Name = "tags")]
		public List<Tag>? Tags { get; set; }
		/// <summary>
		/// The list of networks that the dashboard administrator has privileges on
		/// </summary>
		/// <value>The list of networks that the dashboard administrator has privileges on</value>
		[DataMember(Name = "networks")]
		public List<Network>? Networks { get; set; }
	}
}
