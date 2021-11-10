using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace Meraki.ApiChecker
{
	public static class OpenApiReader
	{
		public static async Task<OpenApiDocument> GetSchemaAsync()
		{
			// Read the OpenApiSpec doc
			var httpClient = new HttpClient
			{
				BaseAddress = new Uri("https://raw.githubusercontent.com/meraki/openapi/")
			};
			var stream = await httpClient.GetStreamAsync("master/openapi/spec2.json").ConfigureAwait(false);
			return new OpenApiStreamReader()
				.Read(stream, out var _);
		}
	}
}
