namespace Meraki.Api.Data;

/// <summary>
/// An API usage
/// </summary>
[DataContract]
public class ApiUsage
{
	/// <summary>
	/// Admin Id
	/// </summary>
	[DataMember(Name = "adminId")]
	public string AdminId { get; set; } = null!;

	/// <summary>
	/// method
	/// </summary>
	[DataMember(Name = "method")]
	public string Method { get; set; } = null!;

	/// <summary>
	/// host
	/// </summary>
	[DataMember(Name = "host")]
	public string Host { get; set; } = null!;

	/// <summary>
	/// path
	/// </summary>
	[DataMember(Name = "path")]
	public string Path { get; set; } = null!;

	/// <summary>
	/// queryString
	/// </summary>
	[DataMember(Name = "queryString")]
	public string QueryString { get; set; } = null!;

	/// <summary>
	/// User Agent
	/// </summary>
	[DataMember(Name = "userAgent")]
	public string UserAgent { get; set; } = null!;

	/// <summary>
	/// Timestamp
	/// </summary>
	[DataMember(Name = "ts")]
	public DateTime Timestamp { get; set; }

	/// <summary>
	/// Response code
	/// </summary>
	[DataMember(Name = "responseCode")]
	public int ResponseCode { get; set; }

	/// <summary>
	/// Source IP
	/// </summary>
	[DataMember(Name = "sourceIp")]
	public string SourceIp { get; set; } = null!;

	/// <summary>
	/// Client information
	/// </summary>
	[DataMember(Name = "client")]
	public ApiUsageClient Client { get; set; } = null!;
}
