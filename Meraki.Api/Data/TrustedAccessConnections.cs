namespace Meraki.Api.Data;

/// <summary>
/// Trusted access connections
/// </summary>
[DataContract]
public class TrustedAccessConnections
{
	/// <summary>
	/// Trusted access config id
	/// </summary>
	[DataMember(Name = "trustedAccessConfigId")]
	public string TrustedAccessConfigId { get; set; } = string.Empty;

	/// <summary>
	/// Downloaded at
	/// </summary>
	[DataMember(Name = "downloadedAt")]
	public string DownloadedAt { get; set; } = string.Empty;

	/// <summary>
	/// Scep completed at
	/// </summary>
	[DataMember(Name = "scepCompletedAt")]
	public string ScepCompletedAt { get; set; } = string.Empty;

	/// <summary>
	/// Last connected at
	/// </summary>
	[DataMember(Name = "lastConnectedAt")]
	public string LastConnectedAt { get; set; } = string.Empty;
}
