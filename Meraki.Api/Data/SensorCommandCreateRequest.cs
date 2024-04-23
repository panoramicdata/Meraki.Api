namespace Meraki.Api.Data;

[DataContract]
public class SensorCommandCreateRequest
{
	/// <summary>
	/// Operation to run on the sensor. 'enableDownstreamPower', 'disableDownstreamPower', and 'cycleDownstreamPower' turn power on/off to the device that is connected downstream of an MT40 power monitor. 'refreshData' causes an MT15 or MT40 device to upload its latest readings so that they are immediately available in the Dashboard API.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "operation")]
	public SensorCommandOperation Operation { get; set; }
}
