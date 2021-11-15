using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Operator
/// </summary>
[DataContract]
public class Operator
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
