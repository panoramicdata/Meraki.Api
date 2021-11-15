using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Schedules
/// </summary>
[DataContract]
public class Schedules
{
	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Ranges
	/// </summary>
	[DataMember(Name = "ranges")]
	public List<Ranges> Ranges { get; set; } = new();
}
