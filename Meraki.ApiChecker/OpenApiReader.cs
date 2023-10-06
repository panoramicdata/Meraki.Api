using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace Meraki.ApiChecker;

public static class OpenApiReader
{
	public static async Task<OpenApiDocument> GetSchemaAsync()
	{
		// Read the OpenApiSpec doc
		var httpClient = new HttpClient
		{
			BaseAddress = new Uri("https://raw.githubusercontent.com/meraki/openapi/")
		};

		// Prefer the beta over "master/openapi/spec3.json";
		const string betaOpenApiSpecPath = "v1-beta/openapi/spec3.json";
		var stream = await httpClient.GetStreamAsync(betaOpenApiSpecPath).ConfigureAwait(false);
		return new OpenApiStreamReader()
			.Read(stream, out var _);
	}
}