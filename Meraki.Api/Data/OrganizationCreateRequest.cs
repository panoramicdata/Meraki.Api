using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganization
	/// </summary>
	[DataContract]
	public partial class OrganizationCreateRequest
	{
		/// <summary>
		/// The name of the organization
		/// </summary>
		/// <value>The name of the organization</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;
	}
}
