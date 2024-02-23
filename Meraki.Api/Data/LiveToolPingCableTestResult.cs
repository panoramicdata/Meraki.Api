namespace Meraki.Api.Data;

/// <summary>
/// Live Tools Cable Test Result
/// </summary>
[DataContract]

public class LiveToolsCableTestResult
{
	/// <summary>
	/// Id of the cable test request. Used to check the status of the request.
	/// </summary>
	[DataMember(Name = "cableTestId")]
	public string CableTestId { get; set; } = string.Empty;

	/// <summary>
	/// An error message for a failed execution
	/// </summary>
	[DataMember(Name = "error")]
	public string Error { get; set; } = string.Empty;

	/// <summary>
	/// Status of the cable test request.
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// GET this url to check the status of your cable test request.
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Cable test request parameters
	/// </summary>
	[DataMember(Name = "request")]
	public LiveToolsCableTestRequest Request { get; set; } = new();

	/// <summary>
	/// Results of the cable test request, one for each requested port.
	/// </summary>
	[DataMember(Name = "results")]
	public List<LiveToolsCableTestResultResult> Results { get; set; } = new();
}
