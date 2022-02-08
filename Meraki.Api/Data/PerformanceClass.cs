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
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "customPerformanceClassId")]
	public string? CustomPerformanceClassId { get; set; }

	/// <summary>
	/// Built in performance class name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "builtinPerformanceClassName")]
	public string? BuiltinPerformanceClassName { get; set; }
}
