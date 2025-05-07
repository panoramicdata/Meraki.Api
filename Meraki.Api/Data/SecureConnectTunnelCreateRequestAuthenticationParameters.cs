namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectTunnelCreateRequestAuthenticationParameters
/// </summary>
[DataContract]
public class SecureConnectTunnelCreateRequestAuthenticationParameters
{
	/// <summary>
	/// A human-readable ID for the tunnel, used to generate the ID portion of the Pre-Shared Key.
	/// If omitted, the ID is generated and provided in response.Tunnels with a device type of ASA
	/// must provide an IP address string for this field.Tunnels with a device type of 'other'
	/// may use either an IP address or a human-readable string. PSK IDs are not automatically generated
	/// for ASA devices.
	/// </summary>
	[DataMember(Name = "idPrefix")]
	public string? IdPrefix { get; set; }

	/// <summary>
	/// The secret portion of a Pre-Shared Key (PSK).
	/// If omitted, a secret is generated and provided in the response.
	/// Secrets are a sequence of 16 to 64 characters, and contain at least one upper
	/// and lowercase letter, one number, and no special characters.
	/// </summary>
	[DataMember(Name = "secret")]
	public string? Secret { get; set; }
}
