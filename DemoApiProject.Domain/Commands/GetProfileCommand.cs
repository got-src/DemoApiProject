using DemoApiProject.Domain.Responses;
using MediatR;

namespace DemoApiProject.Domain.Commands;

public class GetProfileCommand : IRequest<GetProfileResponse>
{
    public GetProfileCommand(int profileId)
    {
        ProfileId = profileId;
    }
    public int ProfileId { get; set; }
}