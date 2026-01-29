class Program
{
  static void Main()
  {
    IApiScanner scanner = new ApiScanner();

    MainMenu menu = new MainMenu(scanner);

    menu.Show();
  }
}
