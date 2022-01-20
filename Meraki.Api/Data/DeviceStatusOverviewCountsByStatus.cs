using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class DeviceStatusOverviewCountsByStatus
{
	/// <summary>
	/// Online
	/// </summary>
	[DataMember(Name = "online")]
	public int Online { get; set; } = 0;

	/// <summary>
	/// Alerting
	/// </summary>
	[DataMember(Name = "alerting")]
	public int Alerting { get; set; } = 0;

	/// <summary>
	/// Offline
	/// </summary>
	[DataMember(Name = "offline")]
	public int Offline { get; set; } = 0;

	/// <summary>
	/// Dormant
	/// </summary>
	[DataMember(Name = "dormant")]
	public int Dormant { get; set; } = 0;
}
