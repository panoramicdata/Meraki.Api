namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Mirror
/// </summary>
[DataContract]
public class SwitchPortMirror
{
	/// <summary>
	/// Mode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
