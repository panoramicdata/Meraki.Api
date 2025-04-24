namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceSwitchPortsMirror
/// </summary>
[DataContract]
public class DeviceSwitchPortsMirrorUpdateRequest
{
	/// <summary>
	/// The switch Identifier
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// My pretty comment
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// Switch role can be source or destination
	/// </summary>
	[DataMember(Name = "role")]
	public string? Role { get; set; }

	/// <summary>
	/// Port mirror tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <inheritdoc cref="DeviceSwitchPortMirrorDestination"/>
	[DataMember(Name = "destination")]
	public DeviceSwitchPortMirrorDestination Destination { get; set; }

	/// <inheritdoc cref="DeviceSwitchPortMirrorSource"/>
	[DataMember(Name = "source")]
	public DeviceSwitchPortMirrorSource Source { get; set; }
}
