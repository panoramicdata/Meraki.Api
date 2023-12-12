namespace Meraki.Api.Data;

/// <summary>
/// Status
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class ActionBatchStatus
{
	/// <summary>
	/// Completed
	/// </summary>
	[DataMember(Name = "completed")]
	public bool Completed { get; set; }

	/// <summary>
	/// Failed
	/// </summary>
	[DataMember(Name = "failed")]
	public bool Failed { get; set; }

	/// <summary>
	/// Errors
	/// </summary>
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = [];

	/// <summary>
	/// Created resourcea
	/// </summary>
	[DataMember(Name = "createdResources")]
	public List<CreatedResources> CreatedResources { get; set; } = [];
}
