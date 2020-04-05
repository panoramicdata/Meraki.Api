using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchStack
	/// </summary>
	[DataContract]
	public partial class SwitchStackCreationRequest
	{
		/// <summary>
		/// The name of the new stack
		/// </summary>
		/// <value>The name of the new stack</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// An array of switch serials to be added into the new stack
		/// </summary>
		/// <value>An array of switch serials to be added into the new stack</value>
		[DataMember(Name = "serials", EmitDefaultValue = false)]
		public List<string> Serials { get; set; } = null!;
	}
}
