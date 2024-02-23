namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Result Result Pair
/// </summary>
[DataContract]

public class LiveToolsCableTestResultResultPair
{
	/// <summary>
	/// The index of the twisted pair tested.
	/// </summary>
	[DataMember(Name = "index")]
	public int Index { get; set; }

	/// <summary>
	/// The detected length of the twisted pair.
	/// </summary>
	[DataMember(Name = "lengthMeters")]
	public int LengthMeters { get; set; }

	/// <summary>
	/// The test result of the twisted pair tested.
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
