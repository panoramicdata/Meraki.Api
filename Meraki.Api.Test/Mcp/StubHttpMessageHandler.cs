namespace Meraki.Api.Test.Mcp;

/// <summary>
/// A scripted inner handler, so the retry, back-off and error-mapping behaviour of
/// MerakiMcpBackingOffHttpMessageHandler can be tested without a server.
/// </summary>
internal sealed class StubHttpMessageHandler : HttpMessageHandler
{
	private readonly Queue<Func<HttpRequestMessage, HttpResponseMessage>> _responses = new();

	public List<HttpRequestMessage> Requests { get; } = [];

	public int SendCount { get; private set; }

	public StubHttpMessageHandler EnqueueStatus(System.Net.HttpStatusCode statusCode, string? retryAfter = null)
	{
		_responses.Enqueue(_request =>
		{
			var response = new HttpResponseMessage(statusCode)
			{
				Content = new StringContent("{}")
			};

			if (retryAfter is not null)
			{
				_ = response.Headers.TryAddWithoutValidation("Retry-After", retryAfter);
			}

			return response;
		});

		return this;
	}

	public StubHttpMessageHandler EnqueueThrow(Exception exception)
	{
		_responses.Enqueue(_ => throw exception);
		return this;
	}

	protected override Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		SendCount++;
		Requests.Add(request);

		cancellationToken.ThrowIfCancellationRequested();

		if (_responses.Count == 0)
		{
			return Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK)
			{
				Content = new StringContent("{}")
			});
		}

		return Task.FromResult(_responses.Dequeue()(request));
	}
}
