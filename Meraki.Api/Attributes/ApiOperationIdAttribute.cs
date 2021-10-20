using System;

namespace Meraki.Api.Attributes
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	internal class ApiOperationIdAttribute : Attribute
	{
		public string OperationId { get; }
		public ApiOperationIdAttribute(string operationId)
		{
			OperationId = operationId;
		}
	}
}