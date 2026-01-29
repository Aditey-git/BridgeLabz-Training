using System;
using System.Reflection;

public class ApiScanner : IApiScanner
{
  public void Scan()
  {
    Type controller = typeof(LabController);

    var methods = controller.GetMethods(
        BindingFlags.Public |
        BindingFlags.Instance |
        BindingFlags.DeclaredOnly
    );

    Console.WriteLine("=== API DOCUMENTATION ===");

    foreach (var method in methods)
    {
      bool publicApi = method.GetCustomAttribute<PublicAPIAttribute>() != null;
      bool auth = method.GetCustomAttribute<RequiresAuthAttribute>() != null;

      Console.WriteLine($"Method: {method.Name}");
      Console.WriteLine(publicApi ? "Public API" : "Missing Public API");
      Console.WriteLine(auth ? "Requires Auth" : "No Auth");
      Console.WriteLine();
    }
  }
}