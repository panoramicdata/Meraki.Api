namespace Meraki.Api.Data;

/// <summary>
/// Performance
/// </summary>
[DataContract]
public class Performance
{
	/// <summary>
	/// Performance score
	/// </summary>
	[DataMember(Name = "perfScore")]
	public double PerfScore { get; set; }
}
