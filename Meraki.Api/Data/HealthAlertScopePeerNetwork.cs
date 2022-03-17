namespace Meraki.Api.Data;

/// <summary>
/// Health alert scope network
/// </summary>
[DataContract]
public class HealthAlertScopePeerNetwork
{
	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
