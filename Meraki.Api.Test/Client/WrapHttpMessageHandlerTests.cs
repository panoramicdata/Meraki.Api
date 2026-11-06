using Meraki.Api.Exceptions;
using System.Net;

namespace Meraki.Api.Test.Client;

/// <summary>
/// <see cref="MerakiClientOptions.WrapHttpMessageHandler"/> lets a caller see, and refuse, every request a <see cref="MerakiClient"/> makes.
/// No credentials or network are needed: the wrapper answers each request itself.
/// </summary>
public class WrapHttpMessageHandlerTests
{
	private static MerakiClientOptions Options(Func<HttpMessageHandler, HttpMessageHandler> wrap) => new()
	{
		ApiKey = "0000000000000000000000000000000000000000",
		UserAgent = "Meraki.Api.Test/1.0",
		MaxAttemptCount = 1,
		WrapHttpMessageHandler = wrap
	};

	[Fact]
	public async Task TheWrapper_SeesTheRequest_AndItsAnswerIsTheClientsAnswer()
	{
		var wrapper = new AnsweringHandler();
		using var client = new MerakiClient(Options(inner => wrapper.Around(inner)));

		var organizations = await client.Organizations.GetOrganizationsAsync(cancellationToken: TestContext.Current.CancellationToken);

		_ = organizations.Should().BeEmpty();
		var request = wrapper.Requests.Should().ContainSingle().Subject;
		_ = request.Method.Should().Be(HttpMethod.Get);
		_ = request.Uri.Should().StartWith("https://api.meraki.com/api/v1/organizations");
	}

	[Fact]
	public async Task AWrapperThatRefuses_FailsTheCall_WithItsReason()
	{
		var wrapper = new AnsweringHandler { Refusal = new InvalidOperationException("Not permitted") };
		using var client = new MerakiClient(Options(inner => wrapper.Around(inner)));

		var act = () => client.Organizations.GetOrganizationsAsync(cancellationToken: TestContext.Current.CancellationToken);

		_ = (await act.Should().ThrowAsync<Refit.ApiRequestException>()).WithInnerException<InvalidOperationException>().WithMessage("Not permitted");
	}

	[Fact]
	public void TheWrapper_IsCreatedOnce_AroundTheClientsOwnHandler()
	{
		var wrapped = new List<HttpMessageHandler>();

		using var client = new MerakiClient(Options(inner =>
		{
			wrapped.Add(inner);
			return new AnsweringHandler().Around(inner);
		}));

		_ = wrapped.Should().ContainSingle().Which.Should().BeOfType<AuthenticatedBackingOffHttpClientHandler>();
	}

	[Fact]
	public void AWrapperThatReturnsNothing_IsAConfigurationError()
	{
		var act = () => new MerakiClient(Options(_ => null!));

		_ = act.Should().Throw<ConfigurationException>().WithMessage("*WrapHttpMessageHandler*");
	}

	[Fact]
	public void DisposingTheClient_DisposesTheWrapper()
	{
		var wrapper = new AnsweringHandler();
		var client = new MerakiClient(Options(inner => wrapper.Around(inner)));

		client.Dispose();

		_ = wrapper.Disposed.Should().BeTrue();
	}

	private sealed class AnsweringHandler : DelegatingHandler
	{
		public List<(HttpMethod Method, string Uri)> Requests { get; } = [];

		public Exception? Refusal { get; init; }

		public bool Disposed { get; private set; }

		public AnsweringHandler Around(HttpMessageHandler inner)
		{
			InnerHandler = inner;
			return this;
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			Requests.Add((request.Method, request.RequestUri!.ToString()));

			return Refusal is not null
				? Task.FromException<HttpResponseMessage>(Refusal)
				: Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("[]") });
		}

		protected override void Dispose(bool disposing)
		{
			Disposed = true;
			base.Dispose(disposing);
		}
	}
}
