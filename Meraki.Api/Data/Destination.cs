namespace Meraki.Api.Data;

/// <summary>
/// Destination
/// </summary>
[DataContract]
public class Destination
{
	/// <summary>
	/// The IP address to test connectivity with
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Description of the testing destination. Optional, defaults to null
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Boolean indicating whether this is the default testing destination (true) or not (false). Defaults to false. Only one default is allowed
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "default")]
	public bool? Default { get; set; }
}
