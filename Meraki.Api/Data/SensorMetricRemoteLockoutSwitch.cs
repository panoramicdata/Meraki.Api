namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: remote lockout switch
/// </summary>
[DataContract]
public class SensorMetricRemoteLockoutSwitch
{
	///<summary>
	/// Locked
	/// </summary>
	[DataMember(Name = "locked")]
	public bool Locked { get; set; }
}