using NArchitecture.Core.Application.Responses;

namespace Application.Features.ApplicationInformations.Queries.GetById;

public class GetByIdApplicationInformationResponse : IResponse
{
    public int Id { get; set; }
    public Guid ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public short ApplicationStateId { get; set; }
}