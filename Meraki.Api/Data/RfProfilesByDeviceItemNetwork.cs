namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Item Network
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class RfProfilesByDeviceItemNetwork
{
	/// <summary>
	/// The network ID.
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
