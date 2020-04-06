using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AddNetworkSwitchStack
	/// </summary>
	[DataContract]
	public partial class NetworkSwitchStackCreationRequest
	{
		/// <summary>
		/// The serial of the switch to be added
		/// </summary>
		/// <value>The serial of the switch to be added</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; } = null!;
	}
}