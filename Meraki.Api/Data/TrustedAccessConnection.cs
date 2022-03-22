namespace Meraki.Api.Data;

/// <summary>
/// Trusted access connections
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class TrustedAccessConnection
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
	public DateTime DownloadedAt { get; set; }

	/// <summary>
	/// Scep completed at
	/// </summary>
	[DataMember(Name = "scepCompletedAt")]
	public DateTime ScepCompletedAt { get; set; }

	/// <summary>
	/// Last connected at
	/// </summary>
	[DataMember(Name = "lastConnectedAt")]
	public DateTime LastConnectedAt { get; set; }
}
