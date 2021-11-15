using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Performance class
/// </summary>
[DataContract]
public class PerformanceClass
{
	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "customPerformanceClassId")]
	public string? CustomPerformanceClassId { get; set; }

	/// <summary>
	/// Built in performance class name
	/// </summary>
	[DataMember(Name = "builtinPerformanceClassName")]
	public string? BuiltinPerformanceClassName { get; set; }
}
