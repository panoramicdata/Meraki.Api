using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Responses
/// </summary>
[DataContract]
public class Responses
{
	/// <summary>
	/// 200
	/// </summary>
	[DataMember(Name = "200")]
	public Responses200 Responses200 { get; set; } = new();
}
