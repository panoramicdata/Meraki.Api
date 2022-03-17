namespace Meraki.Api.Data;

/// <summary>
/// Health alert scope peer
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class HealthAlertScopePeer
{
	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public HealthAlertScopePeerNetwork Network { get; set; } = new();
}
