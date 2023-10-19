namespace Meraki.Api.Data;

[DataContract]
public class SensorCommand
{
	/// <summary>
	/// ID to check the status of the command request
	/// </summary>
	[DataMember(Name = "commandId")]
	public string CommandId { get; set; } = string.Empty;

	/// <summary>
	/// Time when the command was triggered
	/// </summary>
	[DataMember(Name = "CreatedAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// Time when the command was completed
	/// </summary>
	[DataMember(Name = "completedAt")]
	public DateTime CompletedAt { get; set; }

	/// <summary>
	/// Information about the admin who triggered the command
	/// </summary>
	[DataMember(Name = "createdBy")]
	public SensorCommandCreatedby CreatedBy { get; set; } = new();

	/// <summary>
	/// Operation run on the sensor
	/// </summary>
	[DataMember(Name = "operation")]
	public SensorCommandOperation Operation { get; set; }

	/// <summary>
	/// Status of the command request
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Info about the gateway that was used to connect to the sensor
	/// </summary>
	[DataMember(Name = "gateway")]
	public SensorCommandGateway Gateway { get; set; } = new();

	/// <summary>
	/// Array of errors if failed
	/// </summary>
	[DataMember(Name = "errors")]
	public List<string> Errors { get; set; } = new();
}
