using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// C
/// </summary>
public class DiskUsageC
{
	/// <summary>
	/// Used
	/// </summary>
	[DataMember(Name = "used")]
	public int Used { get; set; }

	/// <summary>
	/// Space
	/// </summary>
	[DataMember(Name = "space")]
	public int Space { get; set; }
}
