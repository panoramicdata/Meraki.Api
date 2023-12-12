namespace Meraki.Api.Data;

/// <summary>
/// Modify tags
/// </summary>
[DataContract]
public class ModifyNetworkDeviceTags
{
	/// <summary>
	/// Update action
	/// </summary>
	[DataMember(Name = "updateAction")]
	public string UpdateAction { get; set; } = string.Empty;

	/// <summary>
	/// Ids
	/// </summary>
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope")]
	public List<string> Scope { get; set; } = [];

	/// <summary>
	/// Serials
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// Tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Wifi macs
	/// </summary>
	[DataMember(Name = "wifiMacs")]
	public List<string>? WifiMacs { get; set; }
}
