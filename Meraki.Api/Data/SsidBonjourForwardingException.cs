namespace Meraki.Api.Data;

/// <summary>
/// Undocumented Object June 2023
/// </summary>
[DataContract]
public class SsidBonjourForwardingException
{
	/// <summary>
	/// Undocumented Bool JUne 2023
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
