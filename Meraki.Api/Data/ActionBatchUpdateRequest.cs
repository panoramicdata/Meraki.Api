using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationActionBatch
	/// </summary>
	[DataContract]
	public class ActionBatchUpdateRequest
	{
		/// <summary>
		/// A boolean representing whether or not the batch has been confirmed. This property cannot be unset once it is true.
		/// </summary>
		/// <value>A boolean representing whether or not the batch has been confirmed. This property cannot be unset once it is true.</value>
		[DataMember(Name = "confirmed", EmitDefaultValue = false)]
		public bool? Confirmed { get; set; }
		/// <summary>
		/// Set to true to force the batch to run synchronous. There can be at most 20 actions in synchronous batch.
		/// </summary>
		/// <value>Set to true to force the batch to run synchronous. There can be at most 20 actions in synchronous batch.</value>
		[DataMember(Name = "synchronous", EmitDefaultValue = false)]
		public bool? Synchronous { get; set; }
	}
}
