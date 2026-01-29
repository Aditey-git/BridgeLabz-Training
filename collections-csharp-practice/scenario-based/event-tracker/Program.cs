class Program
{
  static void Main()
  {
    IAuditScanner scanner = new AuditScanner();

    MainMenu menu = new MainMenu(scanner);

    menu.Show();
  }
}
