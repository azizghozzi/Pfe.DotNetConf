using Ardalis.Specification;

namespace Pfe.DotNetConf.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
