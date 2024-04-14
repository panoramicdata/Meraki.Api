namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test ResultResult
/// </summary>
[DataContract]

public class LiveToolsCableTestResultResult
{
	/// <summary>
	/// Speed in Mbps. A speed of 0 indicates the port is down or the port speed is automatic.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "speedMbps")]
	public int SpeedMbps { get; set; }

	/// <summary>
	/// If an error occurred during the cable test, the error message will be populated here.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// The port for which the test was performed.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// The current status of the port. If the cable test is still being performed on the port, "in-progress" is used. If an error occurred during the cable test, "error" is used and the error property will be populated.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Results for each twisted pair within the cable.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pairs")]
	public List<LiveToolsCableTestResultResultPair> Pairs { get; set; } = new();
}
