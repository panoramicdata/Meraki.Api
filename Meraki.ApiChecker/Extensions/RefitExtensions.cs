using Microsoft.OpenApi.Models;

namespace Meraki.ApiChecker.Extensions
{
	public static class RefitExtensions
	{
		public static HttpMethod ToHttpMethod(this OperationType operationType)
			=> operationType switch
			{
				OperationType.Get => HttpMethod.Get,
				OperationType.Put => HttpMethod.Put,
				OperationType.Post => HttpMethod.Post,
				OperationType.Delete => HttpMethod.Delete,
				OperationType.Options => HttpMethod.Options,
				OperationType.Head => HttpMethod.Head,
				OperationType.Patch => HttpMethod.Patch,
				OperationType.Trace => HttpMethod.Trace,
				_ => throw new NotSupportedException($"Cannot convert {nameof(OperationType)} {operationType}"),
			};
	}
}
