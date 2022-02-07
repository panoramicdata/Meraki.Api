namespace Meraki.ApiChecker.Extensions;
public static class TypeExtension
{
	public static string GetNonGenericType(this Type type)
	{
		if (!type.IsGenericType)
		{
			// It's not a generic type, so we assume the FullName is the actual ReturnType that we are interested in
			return type.FullName!;
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
				typeDefinition = type.GetGenericArguments()[0];
			}

			// We believe we have reached the Meraki Type we are interested in
			return typeDefinition.FullName!;

			// Todo - loop through the properties of the found Type
			// Get types used on the return type and further nested levels
			//foreach (var property in typeDefinition.GetProperties())
			//{
			//	var propertyTypes = GetNestedNonGenericTypes(property.GetType());
			//	types.AddRange(propertyTypes);
			//}
		}
	}
}
