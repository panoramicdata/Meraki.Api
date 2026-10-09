namespace Meraki.Api.Data;

/// <summary>
/// The physical interface behind a switch port - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class SwitchPortInterface
{
	/// <summary>
	/// The interface name, for example 'GigabitEthernet1/0/1'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The switch (stack member) number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switch")]
	public int? Switch { get; set; }

	/// <summary>
	/// The module number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "module")]
	public int? Module { get; set; }

	/// <summary>
	/// The slot number. Only null has been observed, so the type is inferred from the neighbouring fields.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "slot")]
	public int? Slot { get; set; }

	/// <summary>
	/// The subslot number. Only null has been observed, so the type is inferred from the neighbouring fields.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subslot")]
	public int? Subslot { get; set; }

	/// <summary>
	/// The port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int? Number { get; set; }
}
