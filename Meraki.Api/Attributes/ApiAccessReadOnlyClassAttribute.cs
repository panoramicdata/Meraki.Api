namespace Meraki.Api.Attributes;

/// <summary>
/// Used to denote how the class can be used with the API as a read-only entity.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class ApiAccessReadOnlyClassAttribute : Attribute;
