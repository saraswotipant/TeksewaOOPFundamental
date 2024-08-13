public class HomePage : IDriver
{
    public string[] MenuItems { get; set; }
    public int Height{ get; set; }
    public int Width{ get; set; }
    public byte[] ProfileAvatar { get; set; }

    public void HandleMenuClick(string menuItem)
    {
        
        Console.WriteLine($"Menu item '{menuItem}'is clicked.");
    }
    public void Login(string userName, string password)
    {
        Console.WriteLine($"User '{userName}' is logged in with password '{password}'.");
    }

    public void Navigate(string URL)
    {
        Console.WriteLine($"Navigating to URL: {URL}");
    }

    public string GetCurrentURL()
    {
        return "http://test.com/";
    }
}