namespace Meraki.Api.Data;

/// <summary>
/// DeviceSwitchPortsMirrorUpdateResponse
/// </summary>
[DataContract]
public class DeviceSwitchPortsMirrorUpdateResponse
{
	/// <summary>
	/// Switch serial Number
	/// </summary>
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Warnings from traffic mirror configuration changes
	/// </summary>
	[DataMember(Name = "warnings")]
	public List<string>? Warnings { get; set; }

	/// <summary>
	/// Switch port mirror configurations
	/// </summary>
	[DataMember(Name = "mirror")]
	public DeviceSwitchPortMirrorConfiguration? Mirror { get; set; }

	/// <inheritdoc cref="DeviceSwitchPortMirrorNetwork"/>
	[DataMember(Name = "network")]
	public DeviceSwitchPortMirrorNetwork? Network { get; set; }
}