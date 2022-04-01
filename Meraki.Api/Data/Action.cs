namespace Meraki.Api.Data;

/// <summary>
/// Action
/// </summary>
[DataContract]
public class Action
{
	/// <summary>
	/// Unique identifier for the resource to be acted on
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "resource")]
	public string Resource { get; set; } = string.Empty;

	/// <summary>
	/// The operation to be used
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "operation")]
	public string Operation { get; set; } = string.Empty;

	/// <summary>
	/// Body
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "body")]
	public object Body { get; set; } = new();
}
