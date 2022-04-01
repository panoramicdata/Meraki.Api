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

	public static List<string> GetDeficientDataModels(this Type type)
	{
		if (type.GetCustomAttribute<ApiAccessReadOnlyClassAttribute>() is not null)
		{
			// It's a read-only class, so return here
			return new List<string>();
		}

		var deficientDataModels = new List<string>();
		foreach (var property in type.GetProperties())
		{
			// Is ApiAccessAttribute or ApiKeyAttribute present on the property?
			if (property.GetCustomAttribute<ApiAccessAttribute>() is null
				&& property.GetCustomAttribute<ApiKeyAttribute>() is null)
			{
				// NO - ApiAccess is not fully denoted for the type
				if (!deficientDataModels.Contains(type.Name))
				{
					deficientDataModels.Add(type.Name);
				}
			}

			// Check properties of the nested object if it's a Meraki class
			var propertyType = property.PropertyType?.GetNonGenericType();
			// Is it a class? AND ensure it's a class we didn't discover yet
			if (propertyType?.IsClass == true && !deficientDataModels.Contains(propertyType.Name))
			{
				deficientDataModels.AddRange(GetDeficientDataModels(propertyType));
			}
		}

		return deficientDataModels;
	}
}
