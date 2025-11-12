namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
internal sealed class ApiOperationIdAttribute(string operationId) : Attribute
{
	/// <summary>
	/// Gets the operation id
	/// </summary>

	public string OperationId { get; } = operationId;
}
