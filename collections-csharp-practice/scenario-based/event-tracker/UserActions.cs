public class UserActions
{

  [AuditTrail("User login")]
  public void Login()
  {
    Console.WriteLine("User logged in");
  }

  [AuditTrail("File Upload")]
  public void UploadFile()
  {
    Console.WriteLine("File Uploaded");
  }

  [AuditTrail("File Delete")]
  public void DeleteFile()
  {
    Console.WriteLine("File Deleted");
  }

  [AuditTrail("View Profile")]
  public void ProfileView()
  {
    Console.WriteLine("Profile Viewed");
  }

}