using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Command logs
/// </summary>
[DataContract]
public class CommandLogs
{
	/// <summary>
	/// Action
	/// </summary>
	[DataMember(Name = "action")]
	public string Action { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Details
	/// </summary>
	[DataMember(Name = "details")]
	public string Details { get; set; } = string.Empty;

	/// <summary>
	/// Dashboard user
	/// </summary>
	[DataMember(Name = "dashboardUser")]
	public string DashboardUser { get; set; } = string.Empty;

	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;
}
