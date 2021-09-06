using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSwitchStack
	/// </summary>
	[DataContract]
	public class SwitchStackCreationRequest
	{
		/// <summary>
		/// The name of the new stack
		/// </summary>
		/// <value>The name of the new stack</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// An array of switch serials to be added into the new stack
		/// </summary>
		/// <value>An array of switch serials to be added into the new stack</value>
		[DataMember(Name = "serials")]
		public List<string> Serials { get; set; } = null!;
	}
}
