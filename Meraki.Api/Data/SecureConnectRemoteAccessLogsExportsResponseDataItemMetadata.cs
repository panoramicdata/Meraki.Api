namespace Meraki.Api.Data;

/// <summary>
/// Export metadata
/// </summary>
[DataContract]
public class SecureConnectRemoteAccessLogsExportsResponseDataItemMetadata
{
	/// <summary>
	/// Current file count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "currentFileLogCount")]
	public int CurrentFileLogCount { get; set; }

	/// <summary>
	/// Duration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// File count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fileCount")]
	public int FileCount { get; set; }

	/// <summary>
	/// Generator count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "generatorCount")]
	public int GeneratorCount { get; set; }

	/// <summary>
	/// Log count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "logCount")]
	public int LogCount { get; set; }

	/// <summary>
	/// Ended at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endedAt")]
	public string EndedAt { get; set; } = string.Empty;

	/// <summary>
	/// Started at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startedAt")]
	public string StartedAt { get; set; } = string.Empty;

	/// <summary>
	/// Limit reached
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "limitReached")]
	public bool LimitReached { get; set; }
}