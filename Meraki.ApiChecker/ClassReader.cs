using Meraki.Api.Attributes;
using System.Reflection;

namespace Meraki.ApiChecker;
public static class ClassReader
{
	internal static List<string> GetDataClasses()
	{
		// Load our data classes
		var apiAssembly = Assembly.Load("Meraki.Api");
		var classes = apiAssembly
			.GetTypes()
			.Where(
				t => t.IsClass
				&& t.Namespace?.StartsWith("Meraki.Api.Data") == true
				).ToList();

		var deficientClasses = new List<string>();

		foreach (var dataClass in classes.OrderBy(c => c.FullName))
		{
			foreach (var property in dataClass.GetProperties())
			{
				var apiAccessAttribute = property.GetCustomAttributes<ApiAccessAttribute>().ToList();
				// Does the property have ApiAccessAttribute?
				if (apiAccessAttribute?.Count > 0)
				{
					// YES - move on to the next property
					continue;
				}
				// NO - take a not of the deficient class

				if (!deficientClasses.Contains(dataClass.FullName!))
				{
					deficientClasses.Add(dataClass.FullName!);
				}
			}
		}

		return deficientClasses;
	}
}
