namespace Meraki.ApiChecker.Data;

public class MissingEndpoint
{
	public string? Method { get; set; }
	public string? Endpoint { get; set; }
	public string? OperationId { get; set; }
	public string? Tags { get; set; }
}