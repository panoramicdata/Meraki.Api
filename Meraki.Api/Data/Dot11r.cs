namespace Meraki.Api.Data;

/// <summary>
/// The current setting for 802.11r
/// </summary>
[DataContract]
public class Dot11r
{
	/// <summary>
	/// (Optional) Whether 802.11r is adaptive or not.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "adaptive")]
	public bool? Adaptive { get; set; }

	/// <summary>
	/// Whether 802.11r is enabled or not.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <inheritdoc />
	public override string ToString()
		=> $"{Adaptive}:{Enabled}";
}
