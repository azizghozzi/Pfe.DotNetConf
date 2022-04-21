using Ardalis.Specification.EntityFrameworkCore;
using Pfe.DotNetConf.SharedKernel.Interfaces;

namespace Pfe.DotNetConf.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
