using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Acls
	/// </summary>
	[DataContract]
	public class Acls
	{
		/// <summary>
		/// Acl id
		/// </summary>
		[DataMember(Name = "aclId")]
		public int AclId { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Ip version
		/// </summary>
		[DataMember(Name = "ipVersion")]
		public string IpVersion { get; set; } = string.Empty;

		/// <summary>
		/// Rules
		/// </summary>
		[DataMember(Name = "rules")]
		public List<AclRules> Rules { get; set; } = new();

		/// <summary>
		/// Created at
		/// </summary>
		[DataMember(Name = "createdAt")]
		public string CreatedAt { get; set; } = string.Empty;

		/// <summary>
		/// Updated at
		/// </summary>
		[DataMember(Name = "updatedAt")]
		public string UpdatedAt { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public int Id { get; set; }
	}
}
