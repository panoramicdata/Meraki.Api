using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Response
/// </summary>
[DataContract]
public class CombineNetworkResponse
{
	/// <summary>
	/// Resulting network
	/// </summary>
	[DataMember(Name = "resultingNetwork")]
	public Network ResultingNetwork { get; set; } = new();
}
