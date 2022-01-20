using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class ApplianceUtilizationSummary
{
	/// <summary>
	/// Network
	/// </summary>
	[DataMember(Name = "network")]
	public ApplianceUtilizationSummaryNetwork Network { get; set; } = new();

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Utilization
	/// </summary>
	[DataMember(Name = "utilization")]
	public ApplianceUtilizationSummaryUtilization Utilization { get; set; } = new();
}
