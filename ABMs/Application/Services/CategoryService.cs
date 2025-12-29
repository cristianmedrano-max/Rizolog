using rizolog.api.abms.Domain.Entities;
using Rizolog.Application.ABMs.Interfaces;

namespace Rizolog.Application.ABMs.Services;

public class CategoryService : ICategoryService
{
    public Category Create(string name)
    {
        return new Category(name);
    }
}
