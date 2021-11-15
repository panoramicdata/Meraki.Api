namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkSmBypassActivationLockAttempt
/// </summary>
[DataContract]
public class SmBypassActivationLockAttemptCreationRequest
{
	/// <summary>
	/// The ids of the devices to attempt activation lock bypass.
	/// </summary>
	/// <value>The ids of the devices to attempt activation lock bypass.</value>
	[DataMember(Name = "ids")]
	public List<string> Ids { get; set; } = null!;
}
