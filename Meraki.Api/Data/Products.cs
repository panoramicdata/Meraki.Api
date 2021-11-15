using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Products
/// </summary>
[DataContract]
public class Products
{
	/// <summary>
	/// Camera
	/// </summary>
	[DataMember(Name = "camera")]
	public Camera Camera { get; set; } = new();

	/// <summary>
	/// Switch
	/// </summary>
	[DataMember(Name = "switch")]
	public Switch Switch { get; set; } = new();
}
