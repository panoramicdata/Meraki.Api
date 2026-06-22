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
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}
