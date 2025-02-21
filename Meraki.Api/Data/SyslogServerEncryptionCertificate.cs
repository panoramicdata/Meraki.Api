namespace Meraki.Api.Data;

/// <summary>
/// Syslog Server Encryption Certificate
/// </summary>
[DataContract]

public class SyslogServerEncryptionCertificate
{
	/// <summary>
	/// The ID of the certificate for encryption with the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
