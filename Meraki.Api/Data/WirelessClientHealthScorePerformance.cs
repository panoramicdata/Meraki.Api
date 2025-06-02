namespace Meraki.Api.Data;

/// <summary>
/// Performance
/// </summary>
[DataContract]
public class WirelessClientHealthScorePerformance
{
	/// <summary>
	/// Latest
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latest")]
	public int Latest { get; set; }

	/// <summary>
	/// Current Connection
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "currentConnection")]
	public int CurrentConnection { get; set; }
}