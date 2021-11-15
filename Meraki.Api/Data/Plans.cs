using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Plans
/// </summary>
[DataContract]
public class Plans
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Price
	/// </summary>
	[DataMember(Name = "price")]
	public string Price { get; set; } = string.Empty;

	/// <summary>
	/// Time limit
	/// </summary>
	[DataMember(Name = "timeLimit")]
	public string TimeLimit { get; set; } = string.Empty;

	/// <summary>
	/// Bandwidth limits
	/// </summary>
	[DataMember(Name = "bandwidthLimits")]
	public BandwidthLimit BandwidthLimits { get; set; } = new();
}
