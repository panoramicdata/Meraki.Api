using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkSmBypassActivationLockAttempt
	/// </summary>
	[DataContract]
	public partial class SmBypassActivationLockAttemptCreationRequest
	{
		/// <summary>
		/// The ids of the devices to attempt activation lock bypass.
		/// </summary>
		/// <value>The ids of the devices to attempt activation lock bypass.</value>
		[DataMember(Name = "ids", EmitDefaultValue = false)]
		public List<string> Ids { get; set; } = null!;
	}
}
