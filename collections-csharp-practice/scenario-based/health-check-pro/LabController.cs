public class LabController
{
  [PublicAPI]
  public void GetTests() { }

  [PublicAPI]
  [RequiresAuth]
  public void BookTest() { }

  public void DeleteTest() { }
}
