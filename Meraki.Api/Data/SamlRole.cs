using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganizationSamlRole
	/// </summary>
	[DataContract]
	public class SamlRole
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// The role of the SAML administrator
		/// </summary>
		/// <value>The role of the SAML administrator</value>
		[DataMember(Name = "role")]
		public string Role { get; set; } = string.Empty;

		/// <summary>
		/// The privilege of the SAML administrator on the organization
		/// </summary>
		/// <value>The privilege of the SAML administrator on the organization</value>
		[DataMember(Name = "orgAccess")]
		public string OrgAccess { get; set; } = string.Empty;

		/// <summary>
		/// The list of tags that the SAML administrator has privleges on
		/// </summary>
		/// <value>The list of tags that the SAML administrator has privleges on</value>
		[DataMember(Name = "tags")]
		public List<Tag> Tags { get; set; } = new();

		/// <summary>
		/// The list of networks that the SAML administrator has privileges on
		/// </summary>
		/// <value>The list of networks that the SAML administrator has privileges on</value>
		[DataMember(Name = "networks")]
		public List<SamlRoleNetwork> Networks { get; set; } = new();
	}
}
