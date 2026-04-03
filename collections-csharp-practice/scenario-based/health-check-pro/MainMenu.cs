using System;

public class MainMenu
{
  private readonly IApiScanner scanner;

  public MainMenu(IApiScanner scanner)
  {
    this.scanner = scanner;
  }

  public void Show()
  {
    while (true)
    {
      Console.WriteLine("\n--- HealthCheckPro ---");
      Console.WriteLine("1. Scan APIs");
      Console.WriteLine("2. Exit");

      Console.Write("Enter choice: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          scanner.Scan();
          break;

        case "2":
          return;

        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }
  }
}
