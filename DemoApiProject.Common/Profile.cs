namespace DemoApiProject.Common;

public interface IProfile
{
    int Id { get; set; }
    string GivenName { get; set; }
    string Surname { get; set; }
    string EmailAddress { get; set; }
}

public class Profile : IProfile
{
    public Profile()
    {
        
    }
    public Profile(IProfile profile)
    {
        Id = profile.Id;
        GivenName = profile.GivenName;
        Surname = profile.Surname;
        EmailAddress = profile.EmailAddress;
    }

    public int Id { get; set; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public string EmailAddress { get; set; }
}