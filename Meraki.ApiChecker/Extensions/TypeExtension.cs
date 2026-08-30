using Meraki.Api.Attributes;
using System.Reflection;

namespace Meraki.ApiChecker.Extensions;
public static class TypeExtension
{
	public static Type? GetNonGenericType(this Type type)
	{
		if (type.IsGenericType)
		{
			// YES - unwrap it
			var nestedType = type.GetGenericArguments()[0];

			// call self with the unwrapped Type
			return GetNonGenericType(nestedType);
		}

		if (type.Namespace?.StartsWith("Meraki.Api.Data", StringComparison.InvariantCulture) == true)
		{
			// It's not a generic type, so we assume it's the actual ReturnType we are interested in
			return type;
		}

		return null;
	}

	public static bool IsGenericList(this Type type)
		=> type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);

	public static List<string> GetDeficientDataModels(this Type type, bool isRoot = true)
	{
		// If we're at the root and this is a generic list then deal with the underlying generic type
		// as attributes won't be assigned to the generic list
		if (isRoot && type.IsGenericList())
		{
			var properType = type.GetNonGenericType() ?? throw new InvalidDataException("Couldn't get underlying generic type");
			return GetDeficientDataModels(properType, false);
		}

		// A root level Task is never Deficient, and a read-only class is exempt
		return (isRoot && type == typeof(Task)) || type.GetCustomAttribute<ApiAccessReadOnlyClassAttribute>() is not null
			? []
			: CollectDeficientDataModels(type);
	}

	private static List<string> CollectDeficientDataModels(Type type)
	{
		var deficientDataModels = new List<string>();

		foreach (var property in type.GetProperties())
		{
			// ApiAccess is not fully denoted for the type unless one of these attributes is present
			if (!IsApiAccessDenoted(property) && !deficientDataModels.Contains(type.Name))
			{
				deficientDataModels.Add(type.Name);
			}

			// Check properties of the nested object if it's a Meraki class we didn't discover yet
			var propertyType = property.PropertyType?.GetNonGenericType();
			if (propertyType?.IsClass == true && !deficientDataModels.Contains(propertyType.Name))
			{
				deficientDataModels.AddRange(GetDeficientDataModels(propertyType, false));
			}
		}

		return deficientDataModels;
	}

	private static bool IsApiAccessDenoted(PropertyInfo property)
		=> property.GetCustomAttribute<ApiAccessAttribute>() is not null
			|| property.GetCustomAttribute<ApiKeyAttribute>() is not null
			|| property.GetCustomAttribute<ApiForeignKeyAttribute>() is not null;
}
