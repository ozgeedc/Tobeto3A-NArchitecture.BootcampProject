using NArchitecture.Core.Application.Responses;

namespace Application.Features.Bootcamps.Queries.GetById;

public class GetByIdBootcampResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid InstructorId { get; set; }
    public short BootcampStateId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}