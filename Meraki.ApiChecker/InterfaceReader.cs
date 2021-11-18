using Meraki.ApiChecker.Models;
using Refit;
using System.Reflection;

namespace Meraki.ApiChecker;

public static class InterfaceReader
{
    internal static Dictionary<string, List<MethodDetails>> GetEndPoints()
    {
        // Load our interface implementations
        var apiAssembly = Assembly.Load("Meraki.Api");
        var interfaces = apiAssembly
            .GetTypes()
            .Where(
                t => t.IsInterface
                && t.Namespace!.StartsWith("Meraki.Api.Interfaces")
                ).ToList();

        var implementedEndpoints = new Dictionary<string, List<MethodDetails>>();

        foreach (var iface in interfaces.OrderBy(i => i.FullName))
        {
            // Look for all the methods and check for ones with Refit HttpMethodAttributes - this will only get public methods, not internal ones
            foreach (var method in iface.GetMethods())
            {
                // There shouldn't be more than one HttpMethodAttribute assigned
                var refitAttribute = method.GetCustomAttributes<HttpMethodAttribute>().SingleOrDefault();
                if (refitAttribute == null)
                {
                    continue;
                }

                if (!implementedEndpoints.TryGetValue(refitAttribute.Path, out var existingList))
                {
                    // Create a new list for this API path
                    implementedEndpoints[refitAttribute.Path]
                        = existingList
                        = new List<MethodDetails>();
                }
                // Add the entry to the list
                existingList.Add(new(method, refitAttribute));
            }
        }
        return implementedEndpoints;
    }
}
