using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// RemoveNetworkSwitchStack
	/// </summary>
	[DataContract]
	public partial class RemoveNetworkSwitchStack
	{
		/// <summary>
		/// The serial of the switch to be removed
		/// </summary>
		/// <value>The serial of the switch to be removed</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; }
	}
}
