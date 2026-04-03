using System;
using System.Reflection;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

public class AuditScanner : IAuditScanner
{
  public void GenerateAuditLogs()
  {
    Type type = typeof(UserActions);
    MethodInfo[] methods = type.GetMethods(
                                            BindingFlags.Public |
                                            BindingFlags.Instance |
                                            BindingFlags.DeclaredOnly
    );
    List<object> logs = new List<object>();

    foreach (var method in methods)
    {
      var attribute = method.GetCustomAttribute<AuditTrailAttribute>();

      if (attribute != null)
      {
        var log = new
        {
          Action = attribute.ActionName,
          Method = method.Name,
          Timestamp = DateTime.Now,
          Class = type.Name
        };

        logs.Add(log);
      }
    }
    string json = JsonSerializer.Serialize(logs, new JsonSerializerOptions { WriteIndented = true });

    Console.WriteLine("\n=== AUDIT LOG (JSON) ===\n");
    Console.WriteLine(json);
  }
}
