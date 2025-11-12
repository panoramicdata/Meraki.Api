namespace Meraki.Api.Data;

/// <summary>
/// Usage
/// </summary>
[DataContract]
public class Usage
{
	/// <summary>
	/// Gets the sent
	/// </summary>
	[DataMember(Name = "sent")]
	public double? Sent { get; set; }

	/// <summary>
	/// Gets the recv
	/// </summary>
	[DataMember(Name = "recv")]
	public double? Recv { get; set; }
}
