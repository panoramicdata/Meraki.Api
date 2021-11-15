namespace Meraki.Api.Data;

/// <summary>
/// Security event
/// </summary>
[DataContract]
public class SecurityEvent
{
	/// <summary>
	/// Ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Event type
	/// </summary>
	[DataMember(Name = "eventType")]
	public string EventType { get; set; } = string.Empty;

	/// <summary>
	/// Client name
	/// </summary>
	[DataMember(Name = "clientName")]
	public string ClientName { get; set; } = string.Empty;

	/// <summary>
	/// Client mac
	/// </summary>
	[DataMember(Name = "clientMac")]
	public string ClientMac { get; set; } = string.Empty;

	/// <summary>
	/// Client ip
	/// </summary>
	[DataMember(Name = "clientIp")]
	public string ClientIp { get; set; } = string.Empty;

	/// <summary>
	/// Src ip
	/// </summary>
	[DataMember(Name = "srcIp")]
	public string SrcIp { get; set; } = string.Empty;

	/// <summary>
	/// Destination ip
	/// </summary>
	[DataMember(Name = "destIp")]
	public string DestIp { get; set; } = string.Empty;

	/// <summary>
	/// Protocol
	/// </summary>
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Priority>
	/// </summary>
	[DataMember(Name = "priority")]
	public string Priority { get; set; } = string.Empty;

	/// <summary>
	/// Classification
	/// </summary>
	[DataMember(Name = "classification")]
	public string Classification { get; set; } = string.Empty;

	/// <summary>
	/// Blocked
	/// </summary>
	[DataMember(Name = "blocked")]
	public bool Blocked { get; set; }

	/// <summary>
	/// Message
	/// </summary>
	[DataMember(Name = "message")]
	public string Message { get; set; } = string.Empty;

	/// <summary>
	/// Signature
	/// </summary>
	[DataMember(Name = "signature")]
	public string Signature { get; set; } = string.Empty;

	/// <summary>
	/// Sig source
	/// </summary>
	[DataMember(Name = "sigSource")]
	public string SigSource { get; set; } = string.Empty;

	/// <summary>
	/// Rule id
	/// </summary>
	[DataMember(Name = "ruleId")]
	public string RuleId { get; set; } = string.Empty;

	/// <summary>
	/// URI
	/// </summary>
	[DataMember(Name = "uri")]
	public string Uri { get; set; } = string.Empty;

	/// <summary>
	/// Canonical name
	/// </summary>
	[DataMember(Name = "canonicalName")]
	public string CanonicalName { get; set; } = string.Empty;

	/// <summary>
	/// Destination port
	/// </summary>
	[DataMember(Name = "destinationPort")]
	public int DestinationPort { get; set; }

	/// <summary>
	/// File hash
	/// </summary>
	[DataMember(Name = "fileHash")]
	public string FileHash { get; set; } = string.Empty;

	/// <summary>
	/// File type
	/// </summary>
	[DataMember(Name = "fileType")]
	public string FileType { get; set; } = string.Empty;

	/// <summary>
	/// File size bytes
	/// </summary>
	[DataMember(Name = "fileSizeBytes")]
	public int FileSizeBytes { get; set; }

	/// <summary>
	/// Disposition
	/// </summary>
	[DataMember(Name = "disposition")]
	public string Disposition { get; set; } = string.Empty;

	/// <summary>
	/// Action
	/// </summary>
	[DataMember(Name = "action")]
	public string Action { get; set; } = string.Empty;
}
