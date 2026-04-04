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

		// Use the master branch OpenAPI v3 spec
		const string openApiSpecPath = "refs/heads/master/openapi/spec3.json";
		var stream = await httpClient.GetStreamAsync(openApiSpecPath).ConfigureAwait(false);
		return new OpenApiStreamReader()
			.Read(stream, out var _);
	}
}