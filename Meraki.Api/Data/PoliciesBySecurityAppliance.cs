using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An object, describing what the policy-connection association is for the security appliance. (Only relevant if the security appliance is actually within the network)
	/// </summary>
	[DataContract]
	public partial class PoliciesBySecurityAppliance
	{
		/// <summary>
		/// Gets or Sets DevicePolicy
		/// </summary>
		[DataMember(Name = "devicePolicy", EmitDefaultValue = false)]
		public DevicePolicy1 DevicePolicy { get; set; }
	}
}
