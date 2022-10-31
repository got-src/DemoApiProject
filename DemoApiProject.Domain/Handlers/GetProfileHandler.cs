using DemoApiProject.Common;
using DemoApiProject.Domain.Commands;
using DemoApiProject.Domain.Responses;
using MediatR;

namespace DemoApiProject.Domain.Handlers;

public class GetProfileHandler : IRequestHandler<GetProfileCommand, GetProfileResponse>
{
    private readonly ILogger<GetProfileHandler> _logger;
    public IEnumerable<IProfile> Profiles = new[]
    {
        new Profile
        {
            Id = 1,
            GivenName = "George",
            Surname = "Costanza",
            EmailAddress = "gcostanza@hotmail.com"
        },
        new Profile
        {
            Id = 2,
            GivenName = "Cosmo",
            Surname = "Kramer",
            EmailAddress = "ckramer@icloud.com"
        }
    };

    public GetProfileHandler(ILogger<GetProfileHandler> logger)
    {
        _logger = logger;
    }

    public Task<GetProfileResponse> Handle(GetProfileCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var profile = Profiles.FirstOrDefault(x => x.Id.Equals(request.ProfileId));
            if (profile is not null)
            {
                return Task.FromResult(new GetProfileResponse(profile));
            }
            
            return Task.FromResult(new GetProfileResponse());
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
            return Task.FromResult(new GetProfileResponse());
        }
    }
}