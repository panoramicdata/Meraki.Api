namespace Meraki.Api.Data;

/// <summary>
/// The current setting for dot1x
/// </summary>
[DataContract]
public class Dot1x
{
	/// <summary>
	/// Dot1x Control Direction
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "controlDirection")]
	public string? ControlDirection { get; set; }
}
