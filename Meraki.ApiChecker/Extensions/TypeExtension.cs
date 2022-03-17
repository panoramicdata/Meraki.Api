using Meraki.Api.Attributes;
using System.Reflection;

namespace Meraki.ApiChecker.Extensions;
public static class TypeExtension
{
	public static Type? GetNonGenericType(this Type type)
	{
		if (!type.IsGenericType)
		{
			if (type.Namespace?.StartsWith("Meraki.Api.Data", StringComparison.InvariantCulture) == true)
			{
				// It's not a generic type, so we assume the FullName is the actual ReturnType that we are interested in
				return type;
			}
		}
		else
		{
			var typeDefinition = type.GetGenericTypeDefinition();
			// Is it a Task<> of something?
			if (typeDefinition == typeof(Task<>))
			{
				// YES - unwrap it
				var nestedType = type.GetGenericArguments()[0];

				// call self with the unwrapped Type
				return GetNonGenericType(nestedType);
			}

			// Is it a List<> of something?
			if (typeDefinition == typeof(List<>) || typeDefinition == typeof(IEnumerable<>))
			{
				// YES - unwrap it
				var nestedType = type.GetGenericArguments()[0];
				return GetNonGenericType(nestedType);
			}
		}

		return null;
	}

	public static bool IsApiAccessAttributeSet(this Type type)
	{
		// Is ApiAccessReadOnlyClassAttribute present on the class?
		if (type.GetCustomAttribute<ApiAccessReadOnlyClassAttribute>() is not null)
		{
			// YES
			return true;
		}
		// NO - look at the properties of the class

		foreach (var property in type.GetProperties())
		{
			// Is ApiAccessAttribute present on the property?
			if (property.GetCustomAttribute<ApiAccessAttribute>() is null)
			{
				// NO - ApiAccess is not fully denoted for the type
				return false;
			}
		}

		// All properties have the ApiAccessAttribute set
		return true;
	}
}
