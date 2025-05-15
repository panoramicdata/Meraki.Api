namespace Meraki.Api.Data;

/// <summary>
/// ThousandEyes Network Create Test Response
/// </summary>
[DataContract]
public class ThousandEyesNetworkCreateTestResponse
{
	/// <summary>
	/// Status of PCC background job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "jobStatus")]
	public string JobStatus { get; set; } = string.Empty;

	/// <summary>
	/// Number of PCC Background Job
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pccBackgroundJob")]
	public string PccBackgroundJob { get; set; } = string.Empty;
}
