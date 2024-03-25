using NArchitecture.Core.Application.Responses;

namespace Application.Features.BlackLists.Commands.Update;

public class UpdatedBlackListResponse : IResponse
{
    public int Id { get; set; }
    public Guid ApplicantId { get; set; }
    public string? Reason { get; set; }
    public DateTime Date { get; set; }
}
