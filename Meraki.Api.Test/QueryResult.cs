using System.Net;

namespace Meraki.Api.Test;

internal sealed class QueryResult
{
	public long DurationMs { get; set; }

	public HttpStatusCode? StatusCode { get; set; }

	public string? ExceptionMessage { get; set; }
}
