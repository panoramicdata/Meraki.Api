namespace Meraki.Api.Data;

[DataContract]
public class SensorCommandCreateRequest
{
	/// <summary>
	/// Operation to run on the sensor. Valid values are 'connect', 'cycleDownstreamPower', 'disableDownstreamPower', 'enableDownstreamPower'
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "operation")]
	public SensorCommandOperation Operation { get; set; }
}
