public class AboutUsPage : HomePage
{
    public string Title { get; set; }
    public int Contacts { get; set; }

    public void InitiatePhone(string number)
    {
        
        Console.WriteLine($"Initiating phone call to {number}.");
    }

    public void InitiateEmail(string email)
    {
       
        Console.WriteLine($"Initiating email to {email}.");
    }
}