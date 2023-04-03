using Meraki.Api.Attributes;
using System.Reflection;
using System.Runtime.Serialization;

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

	public static List<string> GetDeficientDataModels(this Type type, bool isRoot = true, bool isParentClassReadOnly = false)
	{
		// If we're at the root and this is a generic list then deal with the underlying generic type
		// as attributes won't be assigned to the generic list
		if (isRoot && type.IsGenericList())
		{
			var properType = type.GetNonGenericType() ?? throw new InvalidDataException("Couldn't get underlying generic type");
			return GetDeficientDataModels(properType, false);
		}

		// A root level Task is never Deficient
		if (isRoot && type == typeof(Task))
		{
			return new();
		}

		var isClassReadOnly = isParentClassReadOnly || type.GetCustomAttribute<ApiAccessReadOnlyClassAttribute>() is not null;

		var deficientDataModels = new List<string>();
		var dataMemberNames = new Dictionary<string, string>();

		foreach (var property in type.GetProperties())
		{
			var dataMemberAttribute = property.GetCustomAttribute<DataMemberAttribute>();
			if (dataMemberAttribute != null)
			{
				var dataMemberName = dataMemberAttribute.Name ?? "Not set";
				if (dataMemberNames.TryGetValue(dataMemberName, out var existingPropertyName))
				{
					deficientDataModels.Add($"Found {existingPropertyName} already has DataMemberName '{dataMemberName}' when processing {property.Name} property on {type}");
				}
				else
				{
					dataMemberNames[dataMemberName] = property.Name;
				}
			}

			// Is ApiAccessAttribute or ApiKeyAttribute present on the property?
			if (!isClassReadOnly
				&& property.GetCustomAttribute<ApiAccessAttribute>() is null
				&& property.GetCustomAttribute<ApiKeyAttribute>() is null)
			{
				// NO - ApiAccess is not fully denoted for the type
				if (!deficientDataModels.Contains(type.Name))
				{
					deficientDataModels.Add($"{type.Name} is missing ApiAccessAttribute");
				}
			}

			// Check properties of the nested object if it's a Meraki class
			var propertyType = property.PropertyType?.GetNonGenericType();
			// Is it a class? AND ensure it's a class we didn't discover yet
			if (propertyType?.IsClass == true && !deficientDataModels.Contains(propertyType.Name))
			{
				deficientDataModels.AddRange(GetDeficientDataModels(propertyType, false, isClassReadOnly));
			}
		}

		return deficientDataModels;
	}
}
