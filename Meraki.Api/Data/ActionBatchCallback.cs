namespace Meraki.Api.Data;

/// <summary>
/// Action batch
/// </summary>
[DataContract]
public class ActionBatchCallback : IdentifiedItem
{
	/// <summary>
	///	The status of the callback
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	///	The callback URL for the webhook target. This was either provided in the original request or comes from a configured webhook receiver
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
