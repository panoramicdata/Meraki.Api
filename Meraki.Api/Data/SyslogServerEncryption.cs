namespace Meraki.Api.Data;

/// <summary>
/// Syslog Server Encryption
/// </summary>
[DataContract]

public class SyslogServerEncryption
{
	/// <summary>
	/// When true, traffic will be encrypted to the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// The certificate for encryption with the syslog server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "certificate")]
	public SyslogServerEncryptionCertificate? Certificate { get; set; }
}
