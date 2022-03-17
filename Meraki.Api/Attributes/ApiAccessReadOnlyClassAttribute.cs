/// <summary>
/// Used to denote how the class can be used with the API
/// </summary>
namespace Meraki.Api.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class ApiAccessReadOnlyClassAttribute : Attribute
{
}
