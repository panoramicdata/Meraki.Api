namespace Meraki.Api.Data;

/// <summary>
/// Camera Custom Analytics Parameters
/// </summary>
[DataContract]
public class CameraCustomAnalyticsParameters : NamedItem
{
	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value")]
	public string value { get; set; } = string.Empty;
}
