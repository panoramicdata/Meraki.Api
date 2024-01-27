namespace Meraki.Api.Data;

public class SensorInformation
{
	/// <summary>
	/// Metrics
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "metrics")]
	public List<string> Metrics { get; set; } = [];

	/// <summary>
	/// Alert profile ids
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "alertProfileIds")]
	public List<string> AlertProfileIds { get; set; } = [];

	/// <summary>
	/// Sensor information
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "alertingOn")]
	public List<object> AlertingOn { get; set; } = [];
}