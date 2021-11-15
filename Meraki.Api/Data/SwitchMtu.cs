namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSwitchSettingsMtu
/// </summary>
[DataContract]
public class SwitchMtu
{
	/// <summary>
	/// MTU size for the entire network. Default value is 9578.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultMtuSize")]
	public int DefaultMtuSize { get; set; }

	/// <summary>
	/// Override MTU size for individual switches or switch profiles. An empty array will clear overrides.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "overrides")]
	public List<MtuOverride> Overrides { get; set; } = new();
}
