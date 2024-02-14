namespace Meraki.Api.Data;

/// <summary>
/// Switch Port Module
/// </summary>
[DataContract]
public class SwitchPortModule
{
	/// <summary>
	/// Model
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public object? Model { get; set; }
}
