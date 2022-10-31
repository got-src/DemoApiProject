using DemoApiProject.Common;

namespace DemoApiProject.Domain.Responses;

public class GetProfileResponse
{
    public Profile Profile { get; set; }

    public GetProfileResponse()
    {
        
    }

    public GetProfileResponse(IProfile profile)
    {
        Profile = new Profile(profile);
    }
}