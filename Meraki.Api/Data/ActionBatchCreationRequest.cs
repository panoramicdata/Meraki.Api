namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationActionBatch
/// </summary>
[DataContract]
public class ActionBatchCreationRequest
{
	/// <summary>
	/// Set to true for immediate execution. Set to false if the action should be previewed before executing. This property cannot be unset once it is true. Defaults to false.
	/// </summary>
	/// <value>Set to true for immediate execution. Set to false if the action should be previewed before executing. This property cannot be unset once it is true. Defaults to false.</value>
	[DataMember(Name = "confirmed")]
	public bool? Confirmed { get; set; }

	/// <summary>
	/// Set to true to force the batch to run synchronous. There can be at most 20 actions in synchronous batch. Defaults to false.
	/// </summary>
	/// <value>Set to true to force the batch to run synchronous. There can be at most 20 actions in synchronous batch. Defaults to false.</value>
	[DataMember(Name = "synchronous")]
	public bool? Synchronous { get; set; }

	/// <summary>
	/// Details for the callback. Please include either an httpServerId OR url and sharedSecret
	/// </summary>
	[DataMember(Name = "callback")]
	public ActionBatchCreationRequestCallback? Callback { get; set; }

	/// <summary>
	/// A set of changes to make as part of this action (&lt;a href&#x3D;'https://developer.cisco.com/meraki/api/#/rest/guides/action-batches/'&gt;more details&lt;/a&gt;)
	/// </summary>
	/// <value>A set of changes to make as part of this action (&lt;a href&#x3D;'https://developer.cisco.com/meraki/api/#/rest/guides/action-batches/'&gt;more details&lt;/a&gt;)</value>
	[DataMember(Name = "actions")]
	public List<Action> Actions { get; set; } = null!;
}
