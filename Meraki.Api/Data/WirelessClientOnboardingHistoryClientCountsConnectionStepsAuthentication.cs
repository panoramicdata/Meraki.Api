namespace Meraki.Api.Data;

/// <summary>
/// Client connections at auth stage
/// </summary>
[DataContract]
public class WirelessClientOnboardingHistoryClientCountsConnectionStepsAuthentication
{
	/// <summary>
	/// Failed connections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failed")]
	public int Failed { get; set; }

	/// <summary>
	/// Total attempted connections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prospective")]
	public int Prospective { get; set; }

	/// <summary>
	/// Successful connections
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "successful")]
	public int Successful { get; set; }
}