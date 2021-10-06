using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Acl
	/// </summary>
	[DataContract]
	public class AdaptivePolicyAcl : NamedItem
	{
		/// <summary>
		/// Acl id
		/// </summary>
		[ApiKey]
		[DataMember(Name = "aclId")]
		public int AclId { get; set; }

		/// <summary>
		/// Description
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Ip version
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "ipVersion")]
		public string IpVersion { get; set; } = string.Empty;

		/// <summary>
		/// Rules
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "rules")]
		public List<AdaptivePolicyAclRules> Rules { get; set; } = new();

		/// <summary>
		/// Created at
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "createdAt")]
		public string CreatedAt { get; set; } = string.Empty;

		/// <summary>
		/// Updated at
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "updatedAt")]
		public string UpdatedAt { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		//[DataMember(Name = "id")]
		//public int Id { get; set; }
	}
}
