namespace Meraki.Api.Data;

/// <summary>
/// Action batch
/// </summary>
[DataContract]
public class ActionBatch : IdentifiedItem
{
	/// <summary>
	///	Organization id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Organization))]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	///	Set to true for immediate execution. Set to false if the action should be previewed before executing. This property cannot be unset once it is true. Defaults to false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "confirmed")]
	public bool Confirmed { get; set; }

	/// <summary>
	///	Set to true to force the batch to run synchronous.There can be at most 20 actions in synchronous batch.Defaults to false.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "synchronous")]
	public bool Synchronous { get; set; }

	/// <summary>
	///	Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public ActionBatchStatus ActionBatchStatus { get; set; } = new();

	/// <summary>
	/// A set of changes to make as part of this action (<a href='https://developer.cisco.com/meraki/api/#/rest/guides/action-batches/'>more details</a>)
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "actions")]
	public List<Action> Action { get; set; } = new();

	/// <summary>
	/// Information for callback used to send back results
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "callback")]
	public ActionBatchCallback Callback { get; set; } = new();
}
