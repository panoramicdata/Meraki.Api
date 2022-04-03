namespace Meraki.Api.Data;

/// <summary>
/// Status
/// </summary>
[DataContract]
public class WirelessStatus
{
	/// <summary>
	/// Basic service sets
	/// </summary>
	[DataMember(Name = "basicServiceSets")]
	public List<BasicServiceSet> BasicServiceSets { get; set; } = new();
}
