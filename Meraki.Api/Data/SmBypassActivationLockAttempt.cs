namespace Meraki.Api.Data;

/// <summary>
/// Bypass activation lock attempt status
/// </summary>
[DataContract]
public class SmBypassActivationLockAttempt : IdentifiedItem
{
	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Data
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "data")]
	public object Data { get; set; } = new();
}
