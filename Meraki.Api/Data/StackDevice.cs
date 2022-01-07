using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Device
/// </summary>
[DataContract]

public class StackDevice
{
	/// <summary>
	/// Serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Product
	/// </summary>
	[DataMember(Name = "product")]
	public string Product { get; set; } = string.Empty;

	/// <summary>
	/// Model
	/// </summary>
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Last reported at
	/// </summary>
	[DataMember(Name = "lastReportedAt")]
	public string LastReportedAt { get; set; } = string.Empty;

	/// <summary>
	/// Clients
	/// </summary>
	[DataMember(Name = "clients")]
	public StackDeviceClients Clients { get; set; } = new();

	/// <summary>
	/// Switch
	/// </summary>
	[DataMember(Name = "switch")]
	public StackDeviceSwitch Switch { get; set; } = new();

	/// <summary>
	/// Uplinks
	/// </summary>
	[DataMember(Name = "uplinks")]
	public List<StackDeviceUplinks> Uplinks { get; set; } = new();
}
