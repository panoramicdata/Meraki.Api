using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Response
/// </summary>
[DataContract]
public class BypassLockResponse
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Data
	/// </summary>
	[DataMember(Name = "data")]
	public List<string> Data { get; set; } = new();
}
