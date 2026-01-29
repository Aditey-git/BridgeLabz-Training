using System;

public class MainMenu
{
  private readonly IAuditScanner scanner;

  public MainMenu(IAuditScanner scanner)
  {
    this.scanner = scanner;
  }

  public void Show()
  {
    while (true)
    {
      Console.WriteLine("\n--- EventTracker ---");
      Console.WriteLine("1. Generate Audit Log");
      Console.WriteLine("2. Exit");

      Console.Write("Choice: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          scanner.GenerateAuditLogs();
          break;

        case "2":
          return;

        default:
          Console.WriteLine("Invalid Option");
          break;
      }
    }
  }
}
