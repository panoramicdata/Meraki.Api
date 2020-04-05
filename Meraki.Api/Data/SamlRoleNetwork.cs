using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Network2
	/// </summary>
	[DataContract]
	public partial class SamlRoleNetwork
	{
		/// <summary>
		/// The network ID
		/// </summary>
		/// <value>The network ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }
		/// <summary>
		/// The privilege of the SAML administrator on the network
		/// </summary>
		/// <value>The privilege of the SAML administrator on the network</value>
		[DataMember(Name = "access", EmitDefaultValue = false)]
		public string Access { get; set; }
	}
}
