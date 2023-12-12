namespace Meraki.Api.Data;

/// <summary>
/// Clone organization switch device
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class CloneOrganizationSwitchDevices
{
	/// <summary>
	/// Source serial
	/// </summary>
	[DataMember(Name = "sourceSerial")]
	public string SourceSerial { get; set; } = string.Empty;

	/// <summary>
	/// Target serials
	/// </summary>
	[DataMember(Name = "targetSerials")]
	public List<string> TargetSerial { get; set; } = [];
}
