namespace Meraki.Api.Data;

/// <summary>
/// Action batch
/// </summary>
[DataContract]
public class ActionBatch
{
	/// <summary>
	///	Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	///	Organization id
	/// </summary>
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	///	Confirmed
	/// </summary>
	[DataMember(Name = "confirmed")]
	public bool Confirmed { get; set; }

	/// <summary>
	///	Synchronous
	/// </summary>
	[DataMember(Name = "synchronous")]
	public bool Synchronous { get; set; }

	/// <summary>
	///	Status
	/// </summary>
	[DataMember(Name = "status")]
	public ActionBatchStatus ActionBatchStatus { get; set; } = new();

	/// <summary>
	/// Actions
	/// </summary>
	[DataMember(Name = "actions")]
	public List<Action> Action { get; set; } = new();
}
