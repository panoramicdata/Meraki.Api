namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationListUpdateRequest
/// </summary>

[DataContract]
public class SecureConnectDestinationListUpdateRequest
{
	/// <summary>
	/// The name of the destination list.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
