using rizolog.api.abms.Domain.Entities;

namespace Rizolog.Application.ABMs.Interfaces;

public interface ICategoryService
{
    Category Create(string name);
}
