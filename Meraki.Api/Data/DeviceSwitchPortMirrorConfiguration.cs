namespace Meraki.Api.Data;

/// <summary>
/// DeviceSwitchPortMirrorConfiguration
/// </summary>
[DataContract]
public class DeviceSwitchPortMirrorConfiguration
{
	/// <summary>
	/// My pretty comment
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// Switch roele can be source or destination
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
	public DeviceSwitchPortMirrorDestination? Destination { get; set; }

	/// <inheritdoc cref="DeviceSwitchPortMirrorSource"/>
	[DataMember(Name = "source")]
	public DeviceSwitchPortMirrorSource? Source { get; set; }
}