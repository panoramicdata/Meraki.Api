namespace Meraki.Api.Data;

/// <summary>
/// Region of interest
/// </summary>
[DataContract]
public class RegionOfInterest
{
	/// <summary>
	/// x0
	/// </summary>
	[DataMember(Name = "x0")]
	public string X0 { get; set; } = string.Empty;

	/// <summary>
	/// y0
	/// </summary>
	[DataMember(Name = "y0")]
	public string Y0 { get; set; } = string.Empty;

	/// <summary>
	/// x1
	/// </summary>
	[DataMember(Name = "x1")]
	public string X1 { get; set; } = string.Empty;

	/// <summary>
	/// y1
	/// </summary>
	[DataMember(Name = "y1")]
	public string Y1 { get; set; } = string.Empty;
}
