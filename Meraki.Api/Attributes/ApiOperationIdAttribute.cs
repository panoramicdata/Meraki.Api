namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
internal class ApiOperationIdAttribute(string operationId) : Attribute
{
	public string OperationId { get; } = operationId;
}
