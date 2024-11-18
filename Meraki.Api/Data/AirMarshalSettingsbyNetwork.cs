namespace Meraki.Api.Data;

/// <summary>
/// Organization Air Marshal Settings By Network
/// </summary>
[DataContract]
public class AirMarshalSettingsByNetwork
{
	/// <summary>
	/// MetaData
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public AirMarshalSettingsByNetworkMeta Meta { get; set; } = new();

	/// <summary>
	/// List of settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "items")]
	public List<AirMarshalSettings> Items { get; set; } = [];
}
