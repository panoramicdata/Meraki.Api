using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Bssid
/// </summary>
[DataContract]
public class Bssids
{
	/// <summary>
	/// BSSID
	/// </summary>
	[DataMember(Name = "bssid")]
	public string Bssid { get; set; } = string.Empty;

	/// <summary>
	/// Contained
	/// </summary>
	[DataMember(Name = "contained")]
	public bool Contained { get; set; }

	/// <summary>
	/// Detected by
	/// </summary>
	[DataMember(Name = "detectedBy")]
	public List<DetectedBy> DetectedBy { get; set; } = new();
}
