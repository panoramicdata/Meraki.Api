using System.IO;
using System.Reflection;

namespace Meraki.Api;
/// <summary>
/// A custom NewtonsoftJsonContentSerializer to handle retries after missing members are observed
/// </summary>
public class CustomNewtonsoftJsonContentSerializer : IHttpContentSerializer
{
	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
	private readonly NewtonsoftJsonContentSerializer _serializerIgnore;
	private readonly NewtonsoftJsonContentSerializer _serializerError;

	public CustomNewtonsoftJsonContentSerializer(MerakiClientOptions options, ILogger logger)
	{
		_options = options;
		_logger = logger;
		_serializerIgnore = new NewtonsoftJsonContentSerializer(
			new JsonSerializerSettings
			{
				// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
				// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
				// nulls for specific properties, e.g. disassociating port schedule ids from a port
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore,
				Converters = new List<JsonConverter> { new StringEnumConverter() }
			});

		_serializerError = new NewtonsoftJsonContentSerializer(
			new JsonSerializerSettings
			{
				// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
				// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
				// nulls for specific properties, e.g. disassociating port schedule ids from a port
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Error,
				Converters = new List<JsonConverter> { new StringEnumConverter() }
			});
	}

	public async Task<T?> FromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken = default)
		=> _options.JsonMissingMemberHandling switch
		{
			JsonMissingMemberHandling.Ignore => await _serializerIgnore.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			JsonMissingMemberHandling.ThrowOnError => await _serializerError.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			JsonMissingMemberHandling.LogWarningOnErrorAndContinue => await LogWarningOnErrorAndContinueFromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false),
			_ => throw new NotSupportedException()
		};

	private async Task<T?> LogWarningOnErrorAndContinueFromHttpContentAsync<T>(HttpContent content, CancellationToken cancellationToken)
	{
		try
		{
			return await _serializerError.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false);
		}
		catch (JsonSerializationException ex)
		{
			_logger.LogWarning(ex, ex.Message);

			// Reset the stream
			var stream = await content.ReadAsStreamAsync().ConfigureAwait(false);
			stream.Seek(0, SeekOrigin.Begin);

			return await _serializerIgnore.FromHttpContentAsync<T>(content, cancellationToken).ConfigureAwait(false);
		}
	}

	public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
		=> _serializerIgnore.GetFieldNameForProperty(propertyInfo);

	public HttpContent ToHttpContent<T>(T item)
		=> _serializerIgnore.ToHttpContent<T>(item);
}
