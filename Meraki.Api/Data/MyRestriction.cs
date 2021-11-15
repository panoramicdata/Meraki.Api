using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// MyRestriction
/// </summary>
[DataContract]
public class MyRestriction
{
	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value")]
	public bool Value { get; set; }
}
