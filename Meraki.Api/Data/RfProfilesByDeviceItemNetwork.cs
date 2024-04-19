namespace Meraki.Api.Data;

/// <summary>
/// Rf Profiles By Device Item Network
/// </summary>
[DataContract]
public class RfProfilesByDeviceItemNetwork
{
	/// <summary>
	/// The network ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
