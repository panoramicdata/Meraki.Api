namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings Update Request
/// </summary>
[DataContract]
public class AirMarshalSettingsUpdateRequest
{
	/// <summary>
	/// Allows clients to access rogue networks. Blocked by default. Valid values are 'allow', 'block'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultPolicy")]
	public string DefaultPolicy { get; set; } = string.Empty;
}
