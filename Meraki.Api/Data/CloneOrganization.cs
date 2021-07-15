using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CloneOrganization
	/// </summary>
	[DataContract]
	public partial class CloneOrganization
	{
		/// <summary>
		/// The name of the new organization
		/// </summary>
		/// <value>The name of the new organization</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;
	}
}
