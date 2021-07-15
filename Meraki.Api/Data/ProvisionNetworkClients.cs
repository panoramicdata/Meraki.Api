using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// ProvisionNetworkClients
	/// </summary>
	[DataContract]
	public partial class ClientProvisionRequest
	{
		/// <summary>
		/// The MAC address of the client. Required.
		/// </summary>
		/// <value>The MAC address of the client. Required.</value>
		[DataMember(Name = "mac", EmitDefaultValue = false)]
		public string Mac { get; set; } = null!;

		/// <summary>
		/// The display name for the client. Optional. Limited to 255 bytes.
		/// </summary>
		/// <value>The display name for the client. Optional. Limited to 255 bytes.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Gets or Sets DevicePolicy
		/// </summary>
		[DataMember(Name = "devicePolicy", EmitDefaultValue = false)]
		public DevicePolicy DevicePolicy { get; set; }

		/// <summary>
		/// The ID of the desired group policy to apply to the client. Required if &#39;devicePolicy&#39; is set to \&quot;Group policy\&quot;. Otherwise this is ignored.
		/// </summary>
		/// <value>The ID of the desired group policy to apply to the client. Required if &#39;devicePolicy&#39; is set to \&quot;Group policy\&quot;. Otherwise this is ignored.</value>
		[DataMember(Name = "groupPolicyId", EmitDefaultValue = false)]
		public string GroupPolicyId { get; set; } = null!;

		/// <summary>
		/// Gets or Sets PoliciesBySecurityAppliance
		/// </summary>
		[DataMember(Name = "policiesBySecurityAppliance", EmitDefaultValue = false)]
		public PoliciesBySecurityAppliance PoliciesBySecurityAppliance { get; set; } = null!;

		/// <summary>
		/// An object, describing the policy-connection associations for each active SSID within the network. Keys should be the number of enabled SSIDs, mapping to an object describing the client&#39;s policy
		/// </summary>
		/// <value>An object, describing the policy-connection associations for each active SSID within the network. Keys should be the number of enabled SSIDs, mapping to an object describing the client&#39;s policy</value>
		[DataMember(Name = "policiesBySsid", EmitDefaultValue = false)]
		public Dictionary<string, GeneratedObject> PoliciesBySsid { get; set; } = null!;

		/// <summary>
		/// The array of clients to provision
		/// </summary>
		[DataMember(Name = "clients")]
		public List<Clients> Clients { get; set; } = new();
	}
}
