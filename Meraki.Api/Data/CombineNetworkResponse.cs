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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "resultingNetwork")]
	public Network ResultingNetwork { get; set; } = new();
}
